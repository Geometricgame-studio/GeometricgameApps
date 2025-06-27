using All_tools_Form_Apps.Additioinal_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace All_tools_Form_Apps
{
    public partial class Error_shower : Form
    {
        Exception ex;
        public Error_shower(Exception exs, string titles = "發生未預期的錯誤!", string contens = "發生意外的錯誤，請按 [詳細資料] 以取得更多錯誤資訊!")
        {
            InitializeComponent();

            ex = exs;

            this.Text = "於: " + exs.Source + " 發生一個或多個未預期的錯誤!";
            title.Text = titles;
            texts.Text = contens;

            this.SetTopLevel(true);
            this.TopMost = false;
        }

        private void exit_os_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(Environment.ExitCode);
        }

        private void go_front_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void more_info_Click(object sender, EventArgs e)
        {
            new Error_shower_infos(ex).ShowDialog();
        }

        private async void Error_shower_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            SoundPlayer sp = new SoundPlayer(Properties.Resources.Final_error);
            sp.Play();
        }
    }
}
