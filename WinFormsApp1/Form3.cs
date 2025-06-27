using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class Form3 : Form
    {
        string password = "";
        public Form3()
        {
            InitializeComponent();
            hr.Enabled = true;
            minute.Enabled = true;
            second.Enabled = true;
            Start.Enabled = true;
            shutdownmode.Text = "重新啟動 (預設)";
            Target.Text = "Windows 作業系統 (預設)";
            hr.Text = "0";
            minute.Text = "10";
            second.Text = "0";
        }
        Boolean qc = true;
        private async void Start_Click(object sender, EventArgs e)
        {
            int hour = hr.SelectedIndex + 0;
            int min = minute.SelectedIndex + 0;
            int sec = second.SelectedIndex + 0;
            int total_sec = hour * 3600 + min * 60 + sec;
            string zh = "";
            string zm = "";
            string zs = "";
            progressBar.Maximum = total_sec * 8;
            progressBar.Value = total_sec * 8;
            if (hour == -1 || min == -1 || sec == -1)
            {
                MessageBox.Show("參數不能為空!", "參數錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hour < 25 && min < 60 && sec < 60)
                {
                    hr.Enabled = false;
                    minute.Enabled = false;
                    second.Enabled = false;
                    Start.Enabled = false;
                    for (int i = 0; i < total_sec; i++)
                    {
                        if (hour < 10)
                        {
                            zh = "0";
                        }
                        else
                        {
                            zh = "";
                        }
                        if (min < 10)
                        {
                            zm = "0";
                        }
                        else
                        {
                            zm = "";
                        }
                        if (sec < 10)
                        {
                            zs = "0";
                        }
                        else
                        {
                            zs = "";
                        }
                        timer.Text = "" + zh + hour + ":" + zm + min + ":" + zs + sec;
                        await Task.Delay(1000);
                        progressBar.Value -= 8;
                        sec--;
                        this.Text = "計時關機系統       還剩" + "" + zh + hour + ":" + zm + min + ":" + zs + sec;
                        if (sec < 0)
                        {
                            sec = 59;
                            min--;
                        }
                        if (min < 0)
                        {
                            min = 59;
                            hour--;
                        }
                        //shutdown warning
                        if (hour < 1 && min == 1 && sec < 1)
                        {
                            Program.show_notify("您的電腦即將關機或重新啟動!", "您的電腦將在1分鐘內關機或重新啟動，" +
                                "請儘快儲存尚未儲存的檔案，以免變更遺失!", 15000, "warning", false);
                        }
                        if (hour < 1 && min < 1 && sec == 15)
                        {
                            Program.show_notify("您的電腦即將在15秒後關機或重新啟動!", "請記得儲存您所有尚未儲存的檔案!", 14500, "warning", false);
                        }
                    }
                    qc = false;
                    if (Target.SelectedIndex == 0)
                    {
                        if (shutdownmode.SelectedIndex == 1)
                        {
                            string strCmdText;
                            strCmdText = "/C" + "shutdown /r /t 0";
                            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                        }
                        else
                        {
                            string strCmdText;
                            strCmdText = "/C" + "shutdown /s /t 0";
                            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                        }

                        System.Environment.Exit(System.Environment.ExitCode);
                    }
                    else
                    {
                        System.Environment.Exit(System.Environment.ExitCode);
                    }
                }
                else
                {
                    MessageBox.Show("未知的參數值!", "參數錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qc == true)
            {
                MessageBox.Show("為了確保您是家長，所以請在視窗下方輸入驗證碼。", "請使用驗證碼來關閉程式", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void password_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("為了確保您是家長，所以請在下方輸入驗證碼以關閉這個程式\n" +
            "驗證碼為輸入框上的淺灰色提示字元。", "幫助", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void close_password_TextChanged(object sender, EventArgs e)
        {
            if (close_password.Text.Length > 6)
            {
                if (close_password.Text == password)
                {
                    qc = false;
                    this.Close();
                }
                else
                {
                    close_password.Enabled = false;
                    close_password.Text = "驗證碼輸入錯誤!";
                    await Task.Delay(500);
                    close_password.Text = "";
                    close_password.Enabled = true;
                }
            }
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            for (; ; )
            {
                password = "";
                string chinese_password = "";
                List<string> chinese_num = new List<string> { "零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖" };
                for (int i = 0; i < 7; i++)
                {
                    int now_random = new Random().Next(0, 9);
                    chinese_password = chinese_password + chinese_num[now_random];
                    password = password + now_random;

                }
                text2.Text = "驗證碼:   " + chinese_password;
                for (int sec = 45; sec > 0;)
                {
                    password_update.Text = sec.ToString();
                    await Task.Delay(1000);
                    sec--;
                }
            }
        }

        private void Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Target.SelectedIndex == 1)
            {
                shutdownmode.Text = "重新啟動 (預設)";
                shutdownmode.Enabled = false;
            } else
            {
                shutdownmode.Enabled = true;
            }
        }
    }
}
