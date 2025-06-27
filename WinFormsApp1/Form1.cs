using System.Configuration;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : All_tools_Form_Apps.Form_border_style
    {
        List<string> msgtext_list = new List<string> { };
        List<string> msgtitle_list = new List<string> { };
        List<int> msgicon_list = new List<int> { };
        public Form1()
        {
            InitializeComponent();

            title_text.Text = this.Text;
            form_icon.Image = this.Icon.ToBitmap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("您確定要重置嗎?\n這意味著:\n1. 您所有的儲存內容將會被刪除" +
                "\n2. 您的所有變更將會遺失。", "重置內容", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                msgtitle.Text = "";
                msgtext.Text = "";
                msgboxicon.SelectedIndex = -1;
                msgtitle_list.Clear();
                msgtext_list.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("沒有儲存的內容不會被顯示。\n您尚未儲存現在的內容，您是否儲存此內容?", "儲存內容", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                msgtitle_list.Add(msgtitle.Text);
                msgtext_list.Add(msgtext.Text);
                msgicon_list.Add(msgboxicon.SelectedIndex);
            }
            this.Hide();
            for (int i = 0; i < msgtext_list.Count; i++)
            {
                var title = msgtitle_list[i];
                var conten = msgtext_list[i];
                var icon = msgicon_list[i];
                if (icon == 1)
                {
                    MessageBox.Show(conten, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (icon == 2)
                {
                    MessageBox.Show(conten, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (icon == 3)
                {
                    MessageBox.Show(conten, title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (icon == 4)
                {
                    MessageBox.Show(conten, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(conten, title, MessageBoxButtons.OK);
                }
            }
            this.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("您正在離開這個視窗，您確定嗎?", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void nexttool_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_conten_Click(object sender, EventArgs e)
        {
            msgtitle_list.Add(msgtitle.Text);
            msgtext_list.Add(msgtext.Text);
            msgicon_list.Add(msgboxicon.SelectedIndex);
            msgtitle.Text = "";
            msgtext.Text = "";
            msgboxicon.SelectedIndex = -1;
            MessageBox.Show("內容已保存成功!", "儲存成功!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
