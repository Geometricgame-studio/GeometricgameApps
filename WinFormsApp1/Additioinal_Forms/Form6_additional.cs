using All_tools_Form_Apps.Pop_up_windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Additioin_Forms
{
    public partial class Form6_additional : Form6
    {
        string filePath = "";
        string fileName = "";

        public Form6_additional()
        {
            InitializeComponent();
            open_file_funtion();
        }

        private void open_file_funtion()
        {
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
                }
            }
            Saved_text.Text = edit_area.Text;
            this.Text = fileName + " - 文字編輯器";
        }
    }
}
