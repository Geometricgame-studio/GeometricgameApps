using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace All_tools_Form_Apps.Setting
{
    public partial class App_onoff : Form
    {
        public App_onoff()
        {
            InitializeComponent();
        }

        private void All_onoff_CheckedChanged(object sender, EventArgs e)
        {
            if (All_onoff.Checked)
            {
                Windows_maker.Checked = true;
                timing_shutdown.Checked = true;
                games.Checked = true;
                cursor_recorder.Checked = true;
                notepad.Checked = true;
                send_email.Checked = true;
                alarm_clock.Checked = true;
                clock.Checked = true;
                web_browser.Checked = true;
                num_picker.Checked = true;
                media_player.Checked = true;
                youtube_downloader.Checked = true;
            }
            else
            {
                Windows_maker.Checked = false;
                timing_shutdown.Checked = false;
                games.Checked = false;
                cursor_recorder.Checked = false;
                notepad.Checked = false;
                send_email.Checked = false;
                alarm_clock.Checked = false;
                clock.Checked = false;
                web_browser.Checked = false;
                num_picker.Checked = false;
                media_player.Checked = false;
                youtube_downloader.Checked = false;
            }
        }

        private void Windows_maker_CheckedChanged(object sender, EventArgs e)
        {
            if (Windows_maker.Checked)
                Program.lasttool_ok = true;
            else Program.lasttool_ok = false;
        }

        private void timing_shutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (timing_shutdown.Checked)
                Program.shutdown_ok = true;
            else Program.shutdown_ok = false;
        }

        private void games_CheckedChanged(object sender, EventArgs e)
        {
            if (games.Checked)
                Program.games_ok = true;
            else Program.games_ok = false;
        }

        private void cursor_recorder_CheckedChanged(object sender, EventArgs e)
        {
            if (cursor_recorder.Checked)
                Program.open_clicker_ok = true;
            else Program.open_clicker_ok = false;
        }

        private void notepad_CheckedChanged(object sender, EventArgs e)
        {
            if (notepad.Checked)
                Program.notepad_ok = true;
            else Program.notepad_ok = false;
        }

        private void send_email_CheckedChanged(object sender, EventArgs e)
        {
            if (send_email.Checked)
                Program.send_email_ok = true;
            else Program.send_email_ok = false;
        }

        private void alarm_clock_CheckedChanged(object sender, EventArgs e)
        {
            if (alarm_clock.Checked)
                Program.alarm_ok = true;
            else Program.alarm_ok = false;
        }

        private void clock_CheckedChanged(object sender, EventArgs e)
        {
            if (clock.Checked)
                Program.clock_ok = true;
            else Program.clock_ok = false;
        }

        private void web_browser_CheckedChanged(object sender, EventArgs e)
        {
            if (web_browser.Checked)
                Program.browser_ok = true;
            else Program.browser_ok = false;
        }

        private void num_picker_CheckedChanged(object sender, EventArgs e)
        {
            if (num_picker.Checked)
                Program.number_picker_ok = true;
            else Program.number_picker_ok = false;
        }

        private void media_player_CheckedChanged(object sender, EventArgs e)
        {
            if (media_player.Checked)
                Program.media_player_ok = true;
            else Program.media_player_ok = false;
        }

        private void youtube_downloader_CheckedChanged(object sender, EventArgs e)
        {
            if (youtube_downloader.Checked)
                Program.youtube_downloader_ok = true;
            else Program.youtube_downloader_ok = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void App_onoff_Load(object sender, EventArgs e)
        {
            await Task.Delay(10);

            Windows_maker.Checked = Program.lasttool_ok;
            timing_shutdown.Checked = Program.shutdown_ok;
            games.Checked = Program.games_ok;
            cursor_recorder.Checked = Program.open_clicker_ok;
            notepad.Checked = Program.notepad_ok;
            send_email.Checked = Program.send_email_ok;
            alarm_clock.Checked = Program.alarm_ok;
            clock.Checked = Program.clock_ok;
            web_browser.Checked = Program.browser_ok;
            num_picker.Checked = Program.number_picker_ok;
            media_player.Checked = Program.media_player_ok;
            youtube_downloader.Checked = Program.youtube_downloader_ok;
            password.Text = Program.password;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            Program.password = password.Text;
        }

        private void renter_password_Click(object sender, EventArgs e)
        {
            password.Text = "";
        }

        private void savechange_Click(object sender, EventArgs e)
        {
            string filename = "App_onoff_settings.gss";
            string folderPath = @"C:\GeometricgamesApps\using\";
            string contens = ""
                + Program.lasttool_ok + ","
                + Program.shutdown_ok + ","
                + Program.open_clicker_ok + ","
                + Program.computeer_ok + ","
                + Program.send_email_ok + ","
                + Program.alarm_ok + ","
                + Program.clock_ok + ","
                + Program.games_ok + ","
                + Program.media_player_ok + ","
                + Program.youtube_downloader_ok + ","
                + Program.number_picker_ok + ","
                + Program.browser_ok + ","
                + Program.notepad_ok;
            Directory.CreateDirectory(folderPath);

            using (StreamWriter sw = new StreamWriter(folderPath + filename))
            {
                sw.WriteLineAsync(contens);
                Program.show_notify("Geometricgame Apps",
                    "儲存成功! 您的設定將會在以後的每次使用套用!", 1000, "done", false);
            }
            var msgbox = new All_tools_Form_Apps.MessageBoxs.Notepad_messagebox1();
            msgbox.ShowDialog();
        }
    }
}
