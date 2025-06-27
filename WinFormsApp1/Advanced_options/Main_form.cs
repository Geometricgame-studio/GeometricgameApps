using All_tools_Form_Apps.Additioinal_Forms;
using All_tools_Form_Apps.External_res;
using All_tools_Form_Apps.Pop_up_windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace All_tools_Form_Apps.Advanced_options
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
        }

        private void continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_System_login().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CMD().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new run_apps().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string user_name = "";
            try
            {
                StreamReader sr = new StreamReader(@"C:\GeometricgamesApps\using\Updater_exe_path.gss");
                user_name = sr.ReadLineAsync().Result;
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("您尚未建立必須的檔案，請開啟更新下載器來修復這個問題。",
                    "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string result = user_name;

            if (File.Exists(result))
            {
                process1.StartInfo.FileName = result;
                process1.Start();

                Environment.Exit(Environment.ExitCode);
            }
            else
            {
                if (MessageBox.Show("您尚未下載更新啟動器，請至https://freegeometricgames.com/download下載或是在此下載。\n\n是否要立即下載更新啟動器?", "啟動器遺失", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new download_choose("https://drive.usercontent.google.com/u/0/uc?id=12b9L_T3xPtKDI2RScp89bjgxVAKKdKTC&amp;export=download", "All_tools_Form_Apps_auto_updater.exe").ShowDialog();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new BSOD("(_)", "Debug 操作執行完成!", "DEBUG_OPATIONS").ShowDialog();
        }
    }
}
