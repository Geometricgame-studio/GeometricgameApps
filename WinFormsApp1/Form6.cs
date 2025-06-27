using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;

namespace All_tools_Form_Apps
{
    public partial class Form6 : Form
    {
        public string Conten = "";
        string filePath = "";
        string fileName = "";
        Boolean autosave = false;
        public Form6()
        {
            InitializeComponent();
        }

        private async void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Saved_text.Text != edit_area.Text)
            {
                DialogResult result =
                    Show_MessageBox("您即將離開文字編輯器!\n直接離開會導致您對此檔案的變更遺失，您想要在離開之前存檔嗎?", "存檔並離開", "Warning", "YesNoCancle");
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                }
                else if (result == DialogResult.Yes)
                {
                    save_file_funtion();
                }
            }
        }
        //"檔案" 標籤
        private void NewFile_Click(object sender, EventArgs e)
        {
            var o = new All_tools_Form_Apps.Form6();
            o.Show();
        }

        private void save_file_funtion()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog save_file = new SaveFileDialog { Filter = "RTF格式檔案|*.rtf|文字檔案|*.txt|所有檔案 (*.*)|*.*", ValidateNames = true })
                {
                    if (save_file.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(save_file.FileName))
                        {
                            sw.WriteLineAsync(edit_area.Text);
                            fileName = Path.GetFileName(save_file.FileName);
                            filePath = save_file.FileName;
                        }
                        var msgbox = new All_tools_Form_Apps.MessageBoxs.Notepad_messagebox1();
                        msgbox.ShowDialog();
                    }
                    else {
                        var msgbox = new All_tools_Form_Apps.MessageBoxs.Notepad_messagebox1();
                        msgbox.ShowDialog();
                        DialogResult result = 
                            Show_MessageBox("檔案儲存程式遭到取消，是否要重試?", "檔案儲存失敗", "Error", "OKRetry");
                        if (result == DialogResult.Retry) {
                            save_file_funtion();
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(edit_area.Text);
                }
            }
            Saved_text.Text = edit_area.Text;
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            save_file_funtion();
        }

        private void SaveNewFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save_file = new SaveFileDialog { Filter = "RTF格式檔案|*.rtf|文字檔案|*.txt|所有檔案 (*.*)|*.*", ValidateNames = true })
            {
                if (save_file.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(save_file.FileName))
                    {
                        sw.WriteLineAsync(edit_area.Text);
                    }
                    var msgbox = new All_tools_Form_Apps.MessageBoxs.Notepad_messagebox1();
                    msgbox.ShowDialog();
                }
                else {
                    var msgbox = new All_tools_Form_Apps.MessageBoxs.Notepad_messagebox1();
                    msgbox.ShowDialog();
                    Show_MessageBox("儲存檔案程式\n遭到取消", "檔案另存失敗", "Error", "OK");
                }
            }
        }

        private void open_file_funtion() {
            using (OpenFileDialog open_file = new OpenFileDialog()
            {
                Filter = "RTF格式檔案|*.rtf|文字檔案|*.txt|所有檔案 (*.*)|*.*",
                ValidateNames = true,
                Multiselect = false,
                Title = "請選擇檔案",
            })
            {
                if (open_file.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(open_file.FileName))
                    {
                        filePath = open_file.FileName;
                        fileName = Path.GetFileName(open_file.FileName);
                        Task<string> text = sr.ReadToEndAsync();
                        edit_area.Text = text.Result;
                    }
                    Saved_text.Text = edit_area.Text;
                }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (fileName == "Untitled") {
                open_file_funtion();
            } else {
                var o = new All_tools_Form_Apps.Additioin_Forms.Form6_additional();
                o.Show();
            }
            Conten = edit_area.Text;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("您確定要列印此文件嗎?", "列印", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                printPreviewDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
        //"編輯" 標籤
        private void Undo_Click(object sender, EventArgs e)
        {
            edit_area.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            edit_area.Redo();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            edit_area.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            edit_area.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            edit_area.Paste();
        }

        private void Select_all_Click(object sender, EventArgs e)
        {
            edit_area.SelectAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            edit_area.SelectedText = "";
        }
        //"格式" 標籤
        private void Font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            edit_area.SelectionFont = new System.Drawing.Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void HighLight_text_Click(object sender, EventArgs e)
        {
            edit_area.SelectionBackColor = Color.Yellow;
        }
        //NotePad內容 (About)
        private void About_Click(object sender, EventArgs e)
        {
            var o_about = new All_tools_Form_Apps.Pop_up_windows.Notepad_About();
            o_about.ShowDialog();
        }

        private async void edit_area_TextChanged(object sender, EventArgs e)
        {
            if (edit_area.Text == string.Empty)
            {
                Cut.Enabled = false;
                Copy.Enabled = false;
                HighLight_text.Enabled = false;
            }
            else
            {
                Copy.Enabled = true;
                Cut.Enabled = true;
                HighLight_text.Enabled = true;
            }

            if (autosave)
            {
                save_file_funtion();
            }

            await Task.Delay(10);
            if (Saved_text.Text == edit_area.Text)
            {
                this.Text = fileName + " - 文字編輯器";
            }
            else
            {
                this.Text = "*" + fileName + " - 文字編輯器";
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Cut.Enabled = false;
            Copy.Enabled = false;
            Word_warp.Checked = true;
            Saved_text.Visible = false;
            fileName = "Untitled";
        }

        private void Word_warp_Click(object sender, EventArgs e)
        {
            if (Word_warp.Checked == false)
            {
                Word_warp.Checked = true;
                edit_area.WordWrap = true;
            }
            else
            {
                Word_warp.Checked = false;
                edit_area.WordWrap = false;
            }
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Auto_save_Click(object sender, EventArgs e)
        {
            if (Auto_save.Checked == false)
            {
                autosave = true;
                Auto_save.Checked = true;
            }
            else
            {
                autosave = false;
                Auto_save.Checked = false;
            }
        }

        private void Usage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.使用鍵盤輸入文字\n2.使用視窗上方的標籤來進行其他工作\n按 [確定] 以關閉此頁面。", "使用說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                edit_area.SelectionColor = colorDialog1.Color;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("確定要重置嗎? 所有尚未儲存的變更將會遺失!", "重置", "Warning", "OKCancle");
            if (result == DialogResult.Yes)
            {
                edit_area.Text = "";
                Saved_text.Text = "";
                filePath = "";
            }
        }

        private void UnHighlight_text_Click(object sender, EventArgs e)
        {
            edit_area.SelectionBackColor = Color.White;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            var o = new All_tools_Form_Apps.Pop_up_windows.Notepad_findtools();
            o.Show();
        }

        public DialogResult Show_MessageBox (string msg, string title, string icon, string type)
        {
            var open_msgbox = new Form();
            if (type == "OK")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.OK_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else if (type == "OKCancle")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.OKCancle_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else if (type == "OKRetry")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.CloseRetry_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else if (type == "YesNoCancle")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.YesNoCancle_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else {
                MessageBox.Show("MessageBox type is null or undefind type.\n" +
                    "Type error: typemissing\nError code: M0000", "Type missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return open_msgbox.DialogResult;
        }
    }
}
