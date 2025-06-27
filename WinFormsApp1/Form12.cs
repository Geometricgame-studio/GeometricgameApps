using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace All_tools_Form_Apps
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        string results = "";
        Boolean completed = false;

        private async void goto_url_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\GeometricgamesApps\using\browser");
            if (File.Exists(@"C:\GeometricgamesApps\using\browser\get_source_code.bat") == false)
            {
                File.Create(@"C:\GeometricgamesApps\using\browser\get_source_code.bat");
            }
            using (StreamWriter sr = new StreamWriter(@"C:\GeometricgamesApps\using\browser\get_source_code.bat"))
            {
                sr.WriteAsync("curl " + URLs.Text);
                sr.Close();
            }

            completed = false;
            backgroundWorker1.RunWorkerAsync();

            int time = 0;
            while (completed == false)
            {
                richTextBox1.Text = "正在連線...\n" + time + "秒";
                time++;
                await Task.Delay(1000);

                if (time > 20)
                {
                    richTextBox1.Text = ">_<\nError! 回應時間過長!";
                    break;
                }
            }
        }

        private void URLs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                goto_url_Click(sender, e);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "\"C:\\GeometricgamesApps\\using\\browser\\get_source_code.bat\"";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

            results = p.StandardOutput.ReadToEnd();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            completed = true;

            if (results.Split('\n').Count() > 1000)
            {
                richTextBox1.Text = ">_<\n413 原始碼過長!";
            }
            else
            {
                richTextBox1.Text = string.Join(" ", results.Split('\n').Skip(2));
            }
        }
    }
}
