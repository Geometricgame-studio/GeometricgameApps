using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace All_tools_Form_Apps.Pop_up_windows
{
    public partial class BSOD : Form
    {
        public BSOD(string icon_text, string title, string error_code)
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            TITLE.Text = icon_text;
            texts.Text = title;
            label1.Text = "如果您通知了支援人員，請告訴他以下資訊:\r\n\r\n停止代碼: " + error_code;
        }

        int persan = 0;
        private async void BSOD_Load(object sender, EventArgs e)
        {
            TITLE.Width = this.Width;
            complete.Width = this.Width;
            little_text.Width = this.Width;
            pictureBox1.Width = this.Width;
            texts.Width = this.Width;
            label1.Width = this.Width;
            Cursor.Hide();
            int rdn = 0;
            while (persan < 101)
            {
                complete.Text = "" + persan.ToString() + "% 已完成";
                await Task.Delay((rdn = new Random().Next(0, 2500)));
                persan += (rdn = new Random().Next(1, 50));
            }
            Cursor.Show();
            shutdown.Visible = true;
            this.BackColor = Color.Black;
            await Task.Delay(2500);
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
