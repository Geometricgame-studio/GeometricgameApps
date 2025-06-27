using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.MessageBoxs
{
    public partial class YesNoCancle_MessageBox : Form
    {
        string title = "";
        string text = "";
        string icon_name = "";
        public YesNoCancle_MessageBox(string msg_text, string msg_title, string icon)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            title = msg_title;
            text = msg_text;
            icon_name = icon;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_MessageBox_Load(object sender, EventArgs e)
        {
            Error_icon.Visible = false;
            Warning_icon.Visible = false;
            Info_icon.Visible = false;
            question_icon.Visible = false;
            NotFound_icon.Visible = false;
            NoEntry_icon.Visible = false;
            Link_icon.Visible = false;
            this.Text = title;
            Message.Text = text;
            if (icon_name == "Error")
            {
                Error_icon.Visible = true;
                System.IO.Stream str = Properties.Resources.Notify_error;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "Warning")
            {
                Warning_icon.Visible = true;
                System.IO.Stream str = Properties.Resources.Notify_warning;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "Info")
            {
                Info_icon.Visible = true;
                System.IO.Stream str = Properties.Resources.Notify_sound;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "Question")
            {
                question_icon.Visible = true;
                System.IO.Stream str = Properties.Resources.Notify_sound;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "NotFound")
            {
                NotFound_icon.Visible = true;
                System.IO.Stream str = Properties.Resources.Notify_error;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "NoEntry")
            {
                NoEntry_icon.Visible = true;
                System.IO.Stream str = Properties.Resources.Notify_error;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "Link")
            {
                System.IO.Stream str = Properties.Resources.Notify_sound;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else if (icon_name == "none")
            {

            }
            else
            {
                MessageBox.Show("An Error happened while loading MessageBox picture\n" +
                    "Report this Bug -> https://freegeometricgames.com/app/report/bugs " +
                    "-> Web side Not Finshed\n\nError code: M0001\n" +
                    "== Details ==\nType error, icon.type Not Found\n" +
                    "icon.type usage: [type]", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
