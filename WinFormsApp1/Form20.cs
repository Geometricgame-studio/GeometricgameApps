using All_tools_Form_Apps.Additioinal_Forms;
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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void nothing_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form20_addtional("nothing").ShowDialog();
            this.Show();
        }

        private void timer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form20_addtional("showtime").ShowDialog();
            this.Show();
        }

        private void showtext_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form20_addtional("showtext").ShowDialog();
            this.Show();
        }

        private void showpictrue_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form20_addtional("showpic").ShowDialog();
            this.Show();
        }
    }
}
