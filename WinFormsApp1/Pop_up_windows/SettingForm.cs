using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace All_tools_Form_Apps.Pop_up_windows
{
    public partial class SettingForm : Form
    {
        public static Form2 self;
        public SettingForm()
        {
            InitializeComponent();
            opacity.Text = "0.8";
        }
        Boolean qc = true;
        private void settingform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qc == true)
            {
                DialogResult result;
                result = MessageBox.Show("您要在離開之前儲存您的變更嗎?\n" +
                    "為儲存的變更將會遺失。", "儲存設定", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Yes)
                {
                    ChangeOpacity();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void ChangeOpacity()
        {
            double v;
            if (Double.TryParse(opacity.SelectedItem?.ToString(), out v))
            {
                //LoadingForm.menu.Opacity = v;
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            ChangeOpacity();
            qc = false;
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            qc = true;
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            qc = false;
            this.Close();
        }
    }
}
