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
    public partial class Form_border_style : Form
    {
        public Form_border_style()
        {
            InitializeComponent();
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void max_form_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void min_form_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void normal_form_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private async void Form_border_style_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(5);
                this.Opacity += 0.1;
            }
        }

        private async void Form_border_style_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Opacity = 1;
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(5);
                this.Opacity -= 0.1;
            }
            await Task.Delay(50);
        }
    }
}
