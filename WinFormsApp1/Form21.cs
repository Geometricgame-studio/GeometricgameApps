using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace All_tools_Form_Apps
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
            treeView1.AfterSelect += TreeView1_AfterSelect;
            treeView1.BeforeExpand += TreeView1_BeforeExpand;
            listView1.DoubleClick += ListView1_DoubleClick;

            listView1.View = View.List;

            Delete_file.Enabled = false;
            Copy_file.Enabled = false;
            rename_file.Enabled = false;
            Paste_file.Enabled = false;
            Cut_file.Enabled = false;
            Move_file.Enabled = false;
        }

        private void ListView1_DoubleClick(object? sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string filepath = listView1.SelectedItems[0].Tag.ToString();

                try
                {
                    System.Diagnostics.Process.Start(filepath);
                }
                catch (Exception ex)
                {
                    Program.show_msgbox("無法打開檔案", "無法打開已選擇的檔案!\n\n詳細資料:\n" + ex, "Warning", "OK");
                }
            }
        }

        private void TreeView1_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            try
            {
                string[] directories = Directory.GetDirectories(node.Tag.ToString());
                foreach (string directory in directories)
                {
                    TreeNode subNode = new TreeNode(System.IO.Path.GetFileName(directory));
                    subNode.Tag = directory;
                    subNode.Nodes.Add("Loading...");
                    node.Nodes.Add(subNode);
                }
            }
            catch (Exception ex)
            {
                Program.show_msgbox("錯誤!", "發生問題!\n\n詳細資料:\n" + ex, "Error", "OK");
            }
        }

        private void TreeView1_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            listView1.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(System.IO.Path.GetFileName(file));
                    item.Tag = file;
                    item.SubItems.Add(new FileInfo(file).Length.ToString() + "個位元組");
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Program.show_msgbox("錯誤!", "發生問題!\n\n詳細資料:\n" + ex, "Error", "OK");
            }

            folder_path.Text = path;
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                TreeNode node = new TreeNode(drive);
                node.Tag = drive;
                node.Nodes.Add("Loading...");
                treeView1.Nodes.Add(node);
            }
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_file_Click(object sender, EventArgs e)
        {
            string filepath = listView1.SelectedItems[0].Tag.ToString();

            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(filepath, 0,RecycleOption.SendToRecycleBin); 

                Program.show_notify(Path.GetFileName(filepath) + "已移至資源回收筒", "若要復原請至資源回收筒並點擊 [復原]", 2500, "Info", false);
            }
            catch (Exception) {
                Program.show_notify("無法移除檔案", "您可以再試一次!", 2500, "error", false);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Delete_file.Enabled = true;
                Copy_file.Enabled = true;
                rename_file.Enabled = true;
                Paste_file.Enabled = true;
                Cut_file.Enabled = true;
                Move_file.Enabled = true;
            }
            else
            {
                Delete_file.Enabled = false;
                Copy_file.Enabled = false;
                rename_file.Enabled = false;
                Paste_file.Enabled = false;
                Cut_file.Enabled = false;
                Move_file.Enabled = false;
            }
        }

        private void folder_path_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Back_to_top_Click(object sender, EventArgs e)
        {
            int classes = folder_path.Text.Split("\\").Count() - 1;
            string pause_text = folder_path.Text;

            folder_path.Text = "";
            for (int i = 0; i < classes; i++)
            {
                folder_path.Text += pause_text.Split("\\")[i] + "\\";
            }
        }
    }
}
