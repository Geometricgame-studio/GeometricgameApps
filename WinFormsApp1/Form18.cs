using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void choose_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                download_folder.Text = dialog.SelectedPath;
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            download.Text = "下載中請稍後...";
            try
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        using (var s = client.GetStreamAsync(link.Text))
                        {
                            using (var fs = new FileStream(download_folder.Text, FileMode.OpenOrCreate))
                            {
                                try
                                {
                                    s.Result.CopyTo(fs);
                                }
                                catch (Exception ex)
                                {
                                    Program.show_msgbox("存放檔案時發生未知的錯誤", ex.ToString(), "Error", "OK");
                                }
                            }
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        Program.show_msgbox("下載失敗", "請確保您輸入的網址正確並且該檔案存在。", "Error", "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                Program.show_msgbox("HttpClient發生未知的錯誤", ex.ToString(), "Error", "OK");
            }
            download.Text = "下載";
        }
    }
}
