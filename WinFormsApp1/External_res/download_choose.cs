using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.External_res
{
    public partial class download_choose : Form
    {
        string link;
        string exename;
        public download_choose(string links, string exenames)
        {
            InitializeComponent();

            link = links;
            exename = exenames;
        }

        private void choose_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sfd = new FolderBrowserDialog();
            sfd.ShowNewFolderButton = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path.Text = sfd.SelectedPath;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(path.Text);

            if (Path.IsPathRooted(path.Text) && Directory.Exists(path.Text))
            {
                if (String.IsNullOrEmpty(filename.Text))
                {
                    MessageBox.Show("資料夾名稱不能為空", "缺少資料", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (File.Exists(path.Text + "\\" + filename.Text + ".zip"))
                    {
                        if (MessageBox.Show("檔案位置: " + path.Text + "\\" + filename.Text + "已存在，繼續將會覆寫該檔案，要繼續嗎?",
                            "檔案已存在", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            new downloader(link, path.Text + "\\" + filename.Text, auto_unzip.Checked, auto_run.Checked, auto_runplace.Checked, exename).ShowDialog();

                            this.Close();
                        }
                    }
                    else
                    {
                        new downloader(link, path.Text + "\\" + filename.Text, auto_unzip.Checked, auto_run.Checked, auto_runplace.Checked, exename).ShowDialog();

                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("輸入的路徑無效或不存在，請選擇一個有效且存在的路徑。", "路徑無效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void auto_unzip_CheckedChanged(object sender, EventArgs e)
        {
            if (auto_unzip.Checked)
            {
                auto_run.Checked = true;
                auto_runplace.Checked = true;
            }
            else
            {
                auto_run.Checked = false;
                auto_runplace.Checked = false;
            }
        }
    }
}
