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
    public partial class _88day : Form
    {
        public _88day()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            w = this.Width;
            h = this.Height;
        }
        int w;
        int h;
        int pressed = 0;

        private async void Title1_Click(object sender, EventArgs e)
        {
            Press_Tummy();
        }

        private async void _88day_Load(object sender, EventArgs e)
        {
            Press_Tummy();
        }

        private async void Press_Tummy()
        {
            pressed++;
            if (pressed < 11)
            {
                System.IO.Stream str = Properties.Resources.jump_sound_14839;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                for (int sizes = 0; sizes < 26; sizes++)
                {
                    this.Size = new Size(w - sizes * 2, h - sizes * 2);
                    this.Location = new Point(this.Location.X + 1, this.Location.Y + 1);
                    await Task.Delay(1);
                }
                await Task.Delay(20);
                for (int sizes = 25; sizes > -1; sizes--)
                {
                    this.Size = new Size(w - sizes * 2, h - sizes * 2);
                    this.Location = new Point(this.Location.X - 1, this.Location.Y - 1);
                    await Task.Delay(1);
                }
            }
            else {
                BSOD bSOD = new BSOD("😡", "肚ㄐㄧ˙因為你按太多次肚ㄐㄧ˙而生氣了!!!",
                    "DAD_IS_ANGRY");
                bSOD.ShowDialog();
            }
        }

        private void _88day_SizeChanged(object sender, EventArgs e)
        {
            Title1.Size = new Size(this.Width, this.Height);
        }
    }
}
