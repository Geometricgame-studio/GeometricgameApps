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
    public partial class Cattest_password : Form
    {
        public Cattest_password()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (password.Text == "這隻喵很棒:)")
            {
                this.Hide();
                var o = new Form8();
                o.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("您所輸入的驗證碼不正確，請再試一次。", "驗證碼錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
