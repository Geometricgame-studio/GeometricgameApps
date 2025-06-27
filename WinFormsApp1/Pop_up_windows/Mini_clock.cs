using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Pop_up_windows
{
    public partial class Mini_clock : Form
    {
        public Mini_clock()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var o = new Form11();
            o.Show();
            this.Close();
        }

        private async void Mini_clock_Load(object sender, EventArgs e)
        {
            while (true) {
                DateTime now = DateTime.Now;
                time.Text = now.Hour.ToString() + ":" + now.Minute.ToString()
                    + ":" + now.Second.ToString();
                await Task.Delay(1000);
            }
        }
    }
}
