using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Additioinal_Forms
{
    public partial class run_apps : Form
    {
        public run_apps()
        {
            InitializeComponent();
        }

        private void browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "應用程式 (*.exe)|*.exe|所有檔案 (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(textBox1.Text);
            }
            catch (Win32Exception ex) {
                Program.show_msgbox("執行失敗", ex.Message, "Error", "OK");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                open.Enabled = false;
            }
            else {
                open.Enabled = true;
            }
        }
    }
}
