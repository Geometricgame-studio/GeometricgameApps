using All_tools_Form_Apps.External_res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.MessageBoxs
{
    public partial class Update_confirm : Form
    {
        public Update_confirm()
        {
            InitializeComponent();
        }

        private async void Update_confirm_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Notify_sound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            string result = "Loading...\n";

            version.Text = "最新版本: " + result + "目前版本: " + Program.version;

            await Task.Delay(50);
            using (var client = new HttpClient())
            {
                using (var s = client.GetStreamAsync("https://freegeometricgames.com/last_version.txt"))
                {
                    using (var fs = new FileStream(@"C:\GeometricgamesApps\using\last_version.txt", FileMode.OpenOrCreate))
                    {
                        try
                        {
                            s.Result.CopyTo(fs);
                        }
                        catch (AggregateException ex)
                        {
                            Program.show_errors(ex, "無法取得版本資訊", "請確保您已連線至網際網路!");
                            this.Close();
                        }
                    }
                }

                if (File.Exists(@"C:\GeometricgamesApps\using\last_version.txt"))
                {
                    using (StreamReader sr = new StreamReader(@"C:\GeometricgamesApps\using\last_version.txt"))
                    {
                        result = sr.ReadToEnd();
                    }
                }
            }
            System.IO.File.Delete(@"C:\GeometricgamesApps\using\last_version.txt");

            version.Text = "最新版本: " + result + "目前版本: " + Program.version;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\GeometricgamesApps\using\Updater_exe_path.gss");
            string result = sr.ReadLineAsync().Result;
            sr.Close();

            if (File.Exists(result))
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = result;
                p.Start();
                System.Environment.Exit(System.Environment.ExitCode);
            }
            else
            {
                if (MessageBox.Show("您尚未下載更新啟動器，請至https://freegeometricgames.com/download下載或是在此下載。\n\n是否要立即下載更新啟動器?", "啟動器遺失", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new download_choose("https://drive.usercontent.google.com/u/0/uc?id=12b9L_T3xPtKDI2RScp89bjgxVAKKdKTC&amp;export=download", "All_tools_Form_Apps_auto_updater.exe").ShowDialog();
                }
            }
        }
    }
}
