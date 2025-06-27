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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void choose_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "選擇要讀取的檔案";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                infoText.Text = "";

                infoText.Text += "檔案名稱: " + Path.GetFileName(ofd.FileName) + "\n";
                infoText.Text += "檔案副檔名: " + Path.GetExtension(ofd.FileName) + "\n";
                infoText.Text += "檔案屬性: " + File.GetAttributes(ofd.FileName) + "\n";
                infoText.Text += "檔案大小: " + new FileInfo(ofd.FileName).Length + " KB\n";
                infoText.Text += "完整路徑: " + ofd.FileName + "\n";
                infoText.Text += "檔案位置: " + Path.GetDirectoryName(ofd.FileName) + "\n";
                infoText.Text += "最後修改日期: " + File.GetLastWriteTime(ofd.FileName) + "\n";
                infoText.Text += "檔案建立日期: " + File.GetCreationTime(ofd.FileName) + "\n";
                infoText.Text += "最後存取日期: " + File.GetLastAccessTime(ofd.FileName) + "\n";
            }
        }
    }
}
