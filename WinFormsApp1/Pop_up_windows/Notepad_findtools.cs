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
    public partial class Notepad_findtools : Form
    {
        public Notepad_findtools()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Notepad_findtools_Load(object sender, EventArgs e)
        {
            await Task.Delay(10);
            DialogResult result =
                MessageBox.Show("⌈文件編輯器⌋ 的尋找功能尚未完成，您要繼續使用此功能嗎?", "功能尚未完成", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
