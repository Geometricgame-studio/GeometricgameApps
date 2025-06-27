using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class update_conten_info : Form_border_style
    {
        public update_conten_info()
        {
            InitializeComponent();

            new update_complete_mp4_player().ShowDialog();

            title_text.Text = Program.version + " 更新內容:";
            max_form.Visible = false;
            normal_form.Visible = false;
            min_form.Visible = false;
            this.TopMost = true;

            update_conten.Text = "此次更新內容:\n" +
                "[+] 下載專區: Outlooker\n" +
                "[+] 主畫面最小化按鈕\n" +
                "[+] 番茄鐘 (內建)";

            update_conten.Text += "\n\n版本: " + Program.version
                + "\n\n感謝您的使用! 希望這次的更新能讓您獲得更佳的體驗!!\n" +
                "官方網站: https://freegeometricgames.com\n\n" +
                "您必須重新啟動您的應用程式來套用最新版本。 按 [繼續] 以重新啟動";
        }

        private void update_conten_TextChanged(object sender, EventArgs e)
        {
            update_conten.Undo();
        }

        private async void exit_Click(object sender, EventArgs e)
        {
            exit_form();
        }

        private void see_again_Click(object sender, EventArgs e)
        {
            this.Hide();
            var o = new update_complete_mp4_player();
            o.ShowDialog();
            o.Hide();
            this.Show();
        }

        private async void exit_form()
        {
            exit.Enabled = false;
            see_again.Enabled = false;
            close.Enabled = false;
            update_conten.Enabled = false;
            close_form.Enabled = false;
            close_form.BackColor = SystemColors.ScrollBar;
            update_conten.BackColor = SystemColors.ScrollBar;
            update_conten.Text = "正在準備前置作業...\n這個動作將會花費1~10秒。\n請耐心等候...";

            this.Close();
        }

        private void update_conten_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Directory.CreateDirectory("C:\\GeometricgamesApps\\using");

            using (StreamWriter sw = new StreamWriter("C:\\GeometricgamesApps\\using\\version_info.gsf"))
            {
                sw.WriteLineAsync(Program.version);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
