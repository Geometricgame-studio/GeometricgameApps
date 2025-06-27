using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class Login_System_login : Form
    {
        public Login_System_login()
        {
            InitializeComponent();
        }

        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
            txtusername.Text = "";
            txtusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_System().ShowDialog();
            this.Show();
        }

        string name_pas = "";

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\GeometricgamesApps\\using\\logon_info.gss"))
            {
                StreamReader sr = new StreamReader("C:\\GeometricgamesApps\\using\\logon_info.gss");

                name_pas = sr.ReadLineAsync().Result;

                string username_pas = "";
                string password_pas = "";

                byte[] bytes = Encoding.ASCII.GetBytes(txtusername.Text);
                for (int i = 0; i < bytes.Count() - 1; i++)
                {
                    username_pas += Encoding.ASCII.GetBytes(txtusername.Text)[i];
                }

                bytes = Encoding.ASCII.GetBytes(txtpassword.Text);
                for (int i = 0; i < bytes.Count() - 1; i++)
                {
                    password_pas += Encoding.ASCII.GetBytes(txtpassword.Text)[i];
                }
                if (username_pas == name_pas.Split('#')[0] && password_pas == name_pas.Split('#')[1])
                {
                    if (stay_login.Checked)
                    {
                        File.Create("C:\\GeometricgamesApps\\using\\stay_login.gss");
                    }

                    Loading_pic.Visible = true;
                    label1.Text = "正在登入，請稍後...";
                    int rdn = 0;
                    await Task.Delay(rdn = new Random().Next(100, 2500));

                    this.Hide();
                    Program.main_forms.ShowDialog();
                    this.Close();
                }
                else
                {
                    Program.show_msgbox("用戶名稱或密碼錯誤!", "您的用戶名稱或密碼錯誤! 請確認後再試一次。", "Error", "OK");
                    txtusername.Focus();
                }

                sr.Close();
            }
            else
            {
                Program.show_msgbox("您尚未註冊帳戶!", "找不到登入必要的檔案，請註冊一個。", "Error", "OK");

                this.Hide();
                new Login_System().ShowDialog();
                this.Show();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_System_login_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\GeometricgamesApps\\using\\stay_login.gss"))
            {
                this.Hide();
                Program.main_forms.ShowDialog();
                this.Close();
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
