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
    public partial class SveAddsystem : Form
    {
        public SveAddsystem()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            this.MinimizeBox = false;
        }

        private void roomnum_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我們會要求您輸入房號的原因，" +
                "是為了防止不相關人士隨意登入服務系統。\n如有不便，請見諒!", "輸入房號", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean can_reserve = false;

        private void Reserve_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gmail_TextChanged(object sender, EventArgs e)
        {
            can_reserve = true;
            if (gmail.Text == "")
            {
                can_reserve = false;
            }
        }

        private async void SveAddsystem_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (gmail.Text != string.Empty &&
                    roomnum.Text == "9301" || roomnum.Text == "9302")
                {
                    Reserve.Enabled = true;
                }
                else
                {
                    Reserve.Enabled = false;
                }
                await Task.Delay(10);
            }
        }

        private void roomnum_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
