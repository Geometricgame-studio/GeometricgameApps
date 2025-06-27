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
    public partial class Svesystem_password : Form
    {
        public Svesystem_password()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (password.Text == "9301")
            {
                this.Hide();
                var o = new Form9();
                o.ShowDialog();
                this.Close();
            }
            else if (password.Text == "父親節快樂")
            {
                this.Hide();
                var o = new All_tools_Form_Apps.Pop_up_windows._88day();
                o.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("您所輸入的房號錯誤，請再次確認您的房號並重新輸入。",
                    "房號錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            var o = new All_tools_Form_Apps.Pop_up_windows.SveAddsystem();
            o.ShowDialog();
        }
    }
}
