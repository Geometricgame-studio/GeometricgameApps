using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Additioinal_Forms
{
    public partial class Error_shower_infos : Form
    {
        string ex;
        public Error_shower_infos(Exception exs)
        {
            InitializeComponent();

            if (exs == null)
            {
                adv_info.Enabled = false;
                texts.Text = "沒有詳細資料可用\n\n按下 [確定] 以關閉此視窗。";
            }
            else
            {
                ex = exs.ToString();
                texts.Text = exs.Message;
            }

            this.TopMost = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adv_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ex, "錯誤詳細資料", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
