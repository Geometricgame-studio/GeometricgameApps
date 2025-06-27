using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Setting
{
    public partial class App_onoff_password : Form
    {
        public App_onoff_password()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == Program.password)
            {
                this.Hide();
                new App_onoff().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤! 請再試一次!", "密碼錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void App_onoff_password_Load(object sender, EventArgs e)
        {
            if (Program.password == "")
            {
                this.Hide();
                new App_onoff().ShowDialog();
                this.Close();
            }
        }
    }
}
