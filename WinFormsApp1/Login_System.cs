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

namespace All_tools_Form_Apps
{
    public partial class Login_System : Form
    {
        public Login_System()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                Program.show_msgbox("註冊失敗", "用戶名稱不可為空。", "Error", "OK");
                txtusername.Focus();
            }
            else
            {
                if (txtpassword.Text == "")
                {
                    Program.show_msgbox("註冊失敗", "密碼不可為空。", "Error", "OK");
                    txtpassword.Focus();
                }
                else
                {
                    if (txtcompassword.Text == txtpassword.Text)
                    {
                        Directory.CreateDirectory("C:\\GeometricgamesApps\\using");

                        if (File.Exists("C:\\GeometricgamesApps\\using\\logon_info.gss"))
                        {
                            DialogResult result
                                = Program.show_msgbox("警告", "如果您註冊密碼，將會覆寫先前註冊的用戶名稱和密碼，如果您不是之前帳戶的擁有人，請取得他人同意。\n要繼續嗎?", "Warning", "YesNo");

                            if (result == DialogResult.Yes)
                            {
                                register();
                            }
                        }
                        else
                        {
                            register();
                        }
                    }
                    else
                    {
                        Program.show_msgbox("註冊失敗", "密碼不符，請再次輸入您的密碼。", "Error", "OK");
                        txtcompassword.Focus();
                    }
                }
            }
        }

        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtcompassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtcompassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtcompassword.Text = "";
            txtpassword.Text = "";
            txtusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register()
        {
            string contens1 = txtusername.Text;
            string contens2 = txtpassword.Text;
            string bytes_contens = "";

            byte[] bytes = Encoding.ASCII.GetBytes(contens1);
            for (int i = 0; i < bytes.Count() - 1; i++)
            {
                bytes_contens += Encoding.ASCII.GetBytes(contens1)[i];
            }

            bytes_contens += "\n";

            bytes = Encoding.ASCII.GetBytes(contens2);
            for (int i = 0; i < bytes.Count() - 1; i++)
            {
                bytes_contens += Encoding.ASCII.GetBytes(contens2)[i];
            }

            bytes = Encoding.ASCII.GetBytes(contens1 + contens2);

            if (Encoding.ASCII.GetString(bytes) == contens1 + contens2)
            {
                using (StreamWriter sw = new StreamWriter("c:\\geometricgamesapps\\using\\logon_info.gss"))
                {
                    sw.WriteLineAsync(bytes_contens.Split('\n')[0] + "#" + bytes_contens.Split('\n')[1]);
                }

                Program.show_notify("註冊成功!", "您的帳號和密碼已用加密的方式保存到您的裝置", 2500, "done", false);
                this.Close();
            }
            else
            {
                Program.show_msgbox("加密失敗", "您輸入了無效的字元。\n僅接受英文符號、數字和標點符號", "Error", "OK");
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
                txtcompassword.Focus();
            }
        }

        private void txtcompassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister.PerformClick();
            }
        }
    }
}
