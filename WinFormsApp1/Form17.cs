using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void change_filenames()
        {
            if (Directory.Exists(targetFolder.Text))
            {
                try
                {
                    List<string> filesname = new List<string>();
                    List<string> splited_strings = new List<string>();
                    List<string> date_strings = new List<string>();

                    foreach (string file in Directory.EnumerateFiles(targetFolder.Text, "*.*", SearchOption.AllDirectories))
                    {
                        filesname.Add(Path.GetFileName(file));
                    }

                    foreach (string filesname_result in filesname)
                    {
                        string renamed_filename;
                        string renamed_filename_dates;
                        string renamed_filename_plus = "";

                        splited_strings = filesname_result.Split(split_text.Text).ToList();
                        if (splited_strings[1].Substring(4, 2) == site_num.Value.ToString())
                        {
                            renamed_filename_plus = splited_strings[0] + sitetext_join + splited_strings[1];
                        }
                        else
                        {
                            renamed_filename_plus = splited_strings[0] + site_other_join.Text + splited_strings[1];
                        }
                        for (int i = 2; i < splited_strings.Count - 1; i++)
                        {
                            renamed_filename_plus = renamed_filename_plus + split_text.Text + splited_strings[i];
                        }

                        renamed_filename_dates = splited_strings[splited_strings.Count - 1];
                        if (remove_90.Checked)
                        {
                            date_strings = splited_strings[splited_strings.Count - (int)slot_num.Value].Split(".").ToList();
                            renamed_filename_dates = date_strings[0].Split("(")[1];
                            renamed_filename_dates = renamed_filename_dates.Split(")")[0];
                        }

                        renamed_filename = renamed_filename_plus + split_text.Text + renamed_filename_dates + "." + date_strings[1];
                        File.Copy(targetFolder + "\\" + filesname_result, resultFolder.Text + "\\" + renamed_filename, true);
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    Program.show_msgbox("操作執行失敗", "應用程式無法存取您選擇的目標資料夾。", "Error", "OK");
                }
                catch (Exception ex)
                {
                    Program.show_msgbox("操作執行失敗", "執行操作時發生意外錯誤\n\n系統回報訊息:\n" + ex, "Error", "OK");
                }
            }
            else
            {
                Program.show_msgbox("無效的路徑", targetFolder.Text + "不是一個有效的路徑。", "Error", "OK");
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(resultFolder.Text))
            {
                if (site_num.Value > 9 && site_num.Value < 100)
                {
                    if (split_text.Text == "")
                    {
                        Program.show_msgbox("參數缺失", "分隔符號不可為空。", "Error", "OK");
                    }
                    else
                    {
                        if (split_text.Text.Length > 1)
                        {
                            Program.show_msgbox("無效的分隔符號", "分隔符號的長度不得超過1個字元。", "Error", "OK");
                        }
                        else
                        {
                            if (change_2_filename.Checked && text_2_filename.Text == "")
                            {
                                Program.show_msgbox("參數缺失", "副檔名不可為空。", "Error", "OK");
                            }
                            else
                            {
                                change_filenames();
                            }
                        }
                    }
                }
                else
                {
                    Program.show_msgbox("無效的Site編號", site_num.Value + "不是有效的2位數數字。", "Error", "OK");
                }
            }
            else
            {
                Program.show_msgbox("無效的路徑", resultFolder.Text + "不是一個有效的路徑。", "Error", "OK");
            }
        }

        private void choose_target_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                targetFolder.Text = fbd.SelectedPath;
            }
        }

        private void choose_result_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                resultFolder.Text = fbd.SelectedPath;
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }
    }
}
