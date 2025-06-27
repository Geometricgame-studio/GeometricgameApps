using All_tools_Form_Apps.Custom_class;
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

namespace All_tools_Form_Apps.MessageBoxs
{
    public partial class Notify_normal : Form
    {
        int close_delay = 0;
        int msg_num = 0;
        public Notify_normal(string title, string text, int close, string type, int msg_number)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 20, 140);
            this.TopMost = true;
            Head.Text = title;
            Conten.Text = text;
            close_delay = close;
            msg_num = msg_number;

            info.Visible = false;
            error.Visible = false;
            warning.Visible = false;
            complete.Visible = false;
            if (type == "info")
            {
                info.Visible = true;
                this.BackColor = Color.SkyBlue;
                System.IO.Stream str = Properties.Resources.Notify_sound;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (type == "error")
            {
                error.Visible = true;
                this.BackColor = Color.Red;
                System.IO.Stream str = Properties.Resources.Notify_error;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (type == "warning")
            {
                warning.Visible = true;
                this.BackColor = Color.Yellow;
                System.IO.Stream str = Properties.Resources.Notify_warning;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (type == "none")
            {
                this.BackColor = Color.Black;
                Head.ForeColor = Color.White;
                Conten.ForeColor = Color.White;
                System.IO.Stream str = Properties.Resources.Notify_sound;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (type == "done")
            {
                complete.Visible = true;
                this.BackColor = Color.LightGreen;
                System.IO.Stream str = Properties.Resources.complete;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
        }

        private async void Notify_normal_Load(object sender, EventArgs e)
        {
            for (int i = -155; i < 15 * msg_num; i += 5)
            {
                this.Location = new Point(10, i + (this.Height * (msg_num - 1)));
                await Task.Delay(1);
            }
            for (int i = 0; i < close_delay; i += 100)
            {
                timer.Text = ((double)(close_delay - i) / 1000).ToString();
                if (((double)(close_delay - i) / 1000).ToString().Split('.').Count() == 1)
                {
                    timer.Text = ((double)(close_delay - i) / 1000).ToString() + ".0";
                }

                await Task.Delay(100);
            }
            exit_form();
        }

        private async void Exit_Click(object sender, EventArgs e)
        {
            exit_form();
        }

        private async void exit_form()
        {
            
            for (int i = this.Location.Y; i > -155; i -= 5)
            {
                this.Location = new Point(10, i);
                await Task.Delay(1);
            }
            this.Close();
            Program.next_notify();
        }
    }
}
