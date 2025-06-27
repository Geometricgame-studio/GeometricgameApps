using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Setting
{
    public partial class personal_settings : Form
    {
        public personal_settings()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Program.apply_public_settings();
            apply_settings();

            this.Close();
        }

        private void d1_change_fonts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您確定要變更所有主要畫面的預設字體嗎? 調整字體可能會造成一些未預期的顯示錯誤!", "變更預設字體", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FontDialog fd = new FontDialog();

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    Program.defalut_fonts = fd.Font;
                }
            }
        }

        Boolean save_on = false;
        private void personal_settings_Load(object sender, EventArgs e)
        {
            this.Font = Program.defalut_fonts;

            if (File.Exists(@"C:\GeometricgamesApps\using\start_video.gof") && Program.startup_video_on)
            {
                startup_action.Enabled = false;
                startup_action.Checked = true;
                setting_1text.ForeColor = Color.Gray;
                info_bar.Text = "系統啟動動畫這項設定一經開啟就無法關閉，若要關閉請重新啟動應用程式。";
                info_bar.Visible = true;
            }

            save_on = true;
            startup_action.Checked = File.Exists("C:\\GeometricgamesApps\\using\\start_video.gof");
        }

        private void apply_settings()
        {
            if (startup_action.Checked)
            {
                if (!File.Exists(@"C:\GeometricgamesApps\using\start_video.gof"))
                {
                    File.Create(@"C:\GeometricgamesApps\using\start_video.gof");
                }
            }
            else
            {
                if (File.Exists(@"C:\GeometricgamesApps\using\start_video.gof"))
                {
                    File.Delete(@"C:\GeometricgamesApps\using\start_video.gof");
                }
            }
        }

        private void startup_action_CheckedChanged(object sender, EventArgs e)
        {
            if (startup_action.Checked && save_on == false)
            {
                startup_action.Enabled = false;
                setting_1text.ForeColor = Color.Gray;
                info_bar.Text = "系統啟動動畫這項設定一經開啟就無法關閉，若要關閉請重新啟動應用程式。";
                info_bar.Visible = true;

                Program.startup_video_on = true;
            }

            save_on = false;
        }

        private void close_info_bar_Click(object sender, EventArgs e)
        {
            info_bar.Visible = false;
        }

        private void info_bar_VisibleChanged(object sender, EventArgs e)
        {
            if (info_bar.Visible)
            {
                close_info_bar.Visible = true;
            }
            else
            {
                close_info_bar.Visible = false;
            }
        }
    }
}
