using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.External_res
{
    public partial class downloader : Form
    {
        Boolean auto_run;
        Boolean unzip;
        Boolean ofl;
        string link;
        string path;
        string exename;

        public downloader(string links, string paths, Boolean unzips, Boolean auto_runs, Boolean open_file_locations, string exenames)
        {
            InitializeComponent();

            auto_run = auto_runs;
            unzip = unzips;
            link = links;
            path = paths;
            ofl = open_file_locations;
            exename = exenames;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (File.Exists(path + ".zip"))
                {
                    try
                    {
                        File.Delete(path + ".zip");
                    }
                    catch
                    {
                    }
                }

                using (var client = new HttpClient())
                {
                    using (var s = client.GetStreamAsync(link))
                    {
                        using (var fs = new FileStream(path + ".zip", FileMode.OpenOrCreate))
                        {
                            s.Result.CopyTo(fs);
                        }
                    }
                }

                if (backgroundWorker1.CancellationPending == false)
                {
                    if (unzip)
                    {
                        backgroundWorker1.ReportProgress(50);

                        if (Directory.Exists(path))
                        {
                            Directory.Delete(path, true);
                        }

                        Directory.CreateDirectory(path);
                        ZipFile.ExtractToDirectory(path + ".zip", path);
                    }

                    if (auto_run)
                    {
                        backgroundWorker1.ReportProgress(75);

                        Process p = new Process();
                        p.StartInfo.FileName = path + "\\net8.0-windows\\" + exename;
                        p.Start();
                    }

                    if (ofl)
                    {
                        backgroundWorker1.ReportProgress(99);

                        Process p = new Process();
                        p.StartInfo.FileName = "explorer.exe";
                        p.StartInfo.Arguments = path + "\\net8.0-windows";
                        p.Start();
                    }
                }

                backgroundWorker1.ReportProgress(100);
            }
            catch (IOException ex)
            {
                show_errors(ex, "下載時發生錯誤", "檔案讀取失敗! 在試一次可能可以解決您的問題。");
                backgroundWorker1.ReportProgress(100);
            }
            catch (Exception ex)
            {
                show_errors(ex, "下載時發生錯誤", "在試一次可能可以解決您的問題。");
                backgroundWorker1.ReportProgress(100);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            this.Close();
        }

        private void downloader_Load(object sender, EventArgs e)
        {
            step.Text = "正在初始化下載...";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c taskkill /im " + exename + " /F";
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            step.Text = "正在下載資源...";

            backgroundWorker1.RunWorkerAsync();
        }

        private void show_errors(Exception ex, string title, string text)
        {
            Program.show_errors(ex, title, text);
        }

        Boolean qc = false;
        private void downloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!qc)
            {
                if (MessageBox.Show("這將會失去目前所有的下載進度，確定要取消嗎?", "取消下載", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cancel.Enabled = false;

                    step.Text = "正在取消...";
                    title.Text = "正在取消...";
                    backgroundWorker1.CancelAsync();
                }

                e.Cancel = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 50)
            {
                step.Text = "正在解壓縮文件...";
            }
            else if (e.ProgressPercentage == 75)
            {
                step.Text = "正在開啟檔案...";
            }
            else if (e.ProgressPercentage == 99)
            {
                step.Text = "正在開啟資料夾位置...";
            }
            else if (e.ProgressPercentage == 100)
            {
                title.Text = "安裝完成!";
                step.Text = "下載完成!";

                qc = true;
                this.Close();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                qc = true;
                this.Close();
            }
            else if (e.Error != null)
            {
                Program.show_msgbox("下載時發生錯誤!", "抱歉，您的下載流程在某個程序執行時崩潰了! 再試一次可能可以解決您的問題。", "Error", "OK");
            }
        }
    }
}
