using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class update_complete_mp4_player : Form
    {
        public update_complete_mp4_player()
        {
            InitializeComponent();

            this.Hide();
        }

        private async void update_complete_mp4_player_Load(object sender, EventArgs e)
        {
            Cursor.Hide();

            List<string> Path = Application.ExecutablePath.Split('\\').ToList();
            string icon_path = "";
            for (int i = 0; i < Path.Count - 1; i++)
            {
                icon_path = icon_path + Path[i] + "\\";
            }
            if (System.IO.File.Exists(icon_path + "\\update_completed.mp4"))
            {
                File.Delete("C:\\GeometricgamesApps\\using\\update_completed.mp4");
                System.IO.File.Copy(icon_path + "\\update_completed.mp4", "C:\\GeometricgamesApps\\using\\update_completed.mp4", true);
            }

            await Task.Delay(5);

            player1.Visible = true;
            player1.uiMode = "none";
            await Task.Delay(5);

            player1.URL = "C:\\GeometricgamesApps\\using\\update_completed.mp4";
            player1.Ctlcontrols.play();

            this.WindowState = FormWindowState.Maximized;
            player1.Size = new Size(this.Width, this.Height);

            this.Show();

            this.Opacity = 0;
            for (int i = 0; i < 20; i++)
            {
                this.Opacity += 0.05;
                await Task.Delay(1);
            }
            this.Opacity = 1;
        }

        private async void player1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                this.Opacity = 1;
                for (int i = 0; i < 50; i++)
                {
                    this.Opacity -= 0.02;
                    await Task.Delay(1);
                }
                this.Opacity = 0;

                Cursor.Show();
                this.Close();
            }
        }
    }
}
