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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Change_font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            fontDialog1.ShowDialog();
            time.Font = fontDialog1.Font;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            time.ForeColor = colorDialog1.Color;
        }

        private void Mini_window_Click(object sender, EventArgs e)
        {
            var o = new All_tools_Form_Apps.Pop_up_windows.Mini_clock();
            o.Show();
            this.Close();
        }

        private async void Form11_Load(object sender, EventArgs e)
        {
            while (true) {
                DateTime now = DateTime.Now;
                time.Text = now.Year + "/" + now.Month + "/" + now.Day + "\n"
                    + now.Hour + ":" + now.Minute + ":" + now.Second;
                await Task.Delay(1000);
            }
        }
    }
}
