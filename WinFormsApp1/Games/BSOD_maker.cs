using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Games
{
    public partial class BSOD_maker : Form
    {
        public BSOD_maker()
        {
            InitializeComponent();
            templete.Text = "Windows 8 ~ 11";
        }

        private void templete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templete.SelectedIndex != 0)
            {
                Program.show_msgbox("範本無法使用",
                    "抱歉，此範本目前無法使用", "Error", "OK");
                templete.Text = "Windows 8 ~ 11";
            }
        }

        private void titlefont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowHelp = true;
            DialogResult result =
                fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Title.Font = fontDialog1.Font;
            }
        }

        private void fontDialog1_HelpRequest(object sender, EventArgs e)
        {
            Program.show_notify("說明", "您現在正在編輯字型",
                1000, "info", false);
        }

        private void contenfont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowHelp = true;
            DialogResult result =
                fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                conten.Font = fontDialog1.Font;
            }
        }

        private void qrcodefont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowHelp = true;
            DialogResult result =
                fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                qrtext.Font = fontDialog1.Font;
                stopcode.Font = fontDialog1.Font;
                Program.show_notify("提示", "此字型設定將改變2個元件的字型。",
                    1000, "info", false);
            }
        }

        private void BSOD_maker_Load(object sender, EventArgs e)
        {

        }

        private void FullScreen_Click(object sender, EventArgs e)
        {
            settings.Visible = false;

            Title.Text = titletext.Text;
            conten.Text = contentext.Text;
            qrtext.Text = qrcodetext.Text;
            stopcode.Text = stopcode_before.Text + "\n" + stopcodetext.Text;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Program.show_notify("欲離開這個畫面", "請按Alt+F4", 2500, "info", false);
        }
    }
}
