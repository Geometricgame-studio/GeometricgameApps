using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.MessageBoxs
{
    public partial class Notepad_messagebox1 : Form
    {
        Boolean sq = false;
        int rdn = 0;
        public Notepad_messagebox1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private async void Notepad_messagebox1_Load(object sender, EventArgs e)
        {
            await Task.Delay(rdn = new Random().Next(10, 250));
            sq = true;
            this.Close();
        }

        private void Notepad_messagebox1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sq == false)
            {
                e.Cancel = true;
            }
        }
    }
}
