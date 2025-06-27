using All_tools_Form_Apps;
using All_tools_Form_Apps.External_res;
using All_tools_Form_Apps.Pop_up_windows;
using All_tools_Form_Apps.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomato_clock;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {



        List<string> subtitles = new List<string>();

        public Form2()
        {
            InitializeComponent();
            this.Opacity = 1.0;
            this.FormBorderStyle = FormBorderStyle.None;

            subtitles.Add("New UI design!!!");
            subtitles.Add("Website updated!");
            subtitles.Add("Play games on > https://freegeometricgames.com");
            subtitles.Add("Happy for your holiday");
            subtitles.Add("Enjoy using pleaseeeeeeeeeeeee!");
            subtitles.Add("Visit our youtube channel using name > @Geometricgame");
            subtitles.Add("Be a nice person!");
            subtitles.Add("Font has been CHANGED!!");

            version.Text = "Geometricgames " + Program.version;

            timer1.Start();
        }


        private void lasttool_Click(object sender, EventArgs e)
        {
            if (Program.lasttool_ok)
            {
                var open_from = new Form1();
                open_from.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            if (Program.shutdown_ok)
            {
                var shutdown_timer = new All_tools_Form_Apps.Form3();
                shutdown_timer.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void open_clicker_Click(object sender, EventArgs e)
        {
            if (Program.open_clicker_ok)
            {
                var shutdown_timer = new All_tools_Form_Apps.Form4();
                shutdown_timer.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void open_computer_Click(object sender, EventArgs e)
        {
            if (Program.computeer_ok)
            {
                var computer = new All_tools_Form_Apps.Form5();
                computer.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void open_setting_Click(object sender, EventArgs e)
        {
            qc = true;
            Form shutdown = new shutdown_app("restart_opt", 0, 0);
            shutdown.Show();
        }

        private void Task_Manager_Click(object sender, EventArgs e)
        {
            if (Program.notepad_ok)
            {
                var o = new All_tools_Form_Apps.Form6();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void PlayGames_Click(object sender, EventArgs e)
        {
            if (Program.games_ok)
            {
                var o = new All_tools_Form_Apps.Pop_up_windows.GamesMenu();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void send_email_Click(object sender, EventArgs e)
        {
            if (Program.send_email_ok)
            {
                send_email.Enabled = false;
                var o = new All_tools_Form_Apps.Form7();
                o.ShowDialog();
                send_email.Enabled = true;
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\GeometricgamesApps\using\cancel_message.gos") == false)
            {
                new All_tools_Form_Apps.MessageBoxs.Messages_showder().Show();
            }

            if (Environment.OSVersion.Version.Build < 22000)
            {
                windows_version_w.Visible = true;
                windows_version_w.Text += Environment.OSVersion.Version.Build.ToString();
            }

            taskBar.Visible = false;

            opa_in();
            daytimes();
            show_taskpage(1);

            int i = 0;
            int rdn = 0;

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            while (true)
            {
                string shown_text = subtitles[rdn = new Random().Next(0, subtitles.Count)];
                sub_title.Text = "";

                int j = 0;
                while (sub_title.Text.Length != shown_text.Length)
                {
                    sub_title.Text = shown_text.Substring(0, j);
                    j++;

                    await Task.Delay(25);
                }
                await Task.Delay(5000);
                j = shown_text.Length;
                while (sub_title.Text.Length != 0)
                {
                    sub_title.Text = shown_text.Substring(0, j);
                    j--;

                    await Task.Delay(25);
                }
            }
        }

        private void Close_Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Boolean qc = false;
        private async void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qc == false)
            {
                DialogResult result =
                    Program.show_msgbox("離開", "您確定要離開嗎?\n感謝您的使用!!!",
                        "Warning", "YesNo");
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                    opa_out();
                }
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void cattest_Click(object sender, EventArgs e)
        {
            var o = new All_tools_Form_Apps.Pop_up_windows.Cattest_password();
            o.ShowDialog();
        }

        private void svesystem_Click(object sender, EventArgs e)
        {
            var o = new All_tools_Form_Apps.Pop_up_windows.Svesystem_password();
            o.ShowDialog();
        }

        private void Alarm_Click(object sender, EventArgs e)
        {
            if (Program.alarm_ok)
            {
                var o = new All_tools_Form_Apps.Form10();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void Clock_Click(object sender, EventArgs e)
        {
            if (Program.clock_ok)
            {
                var o = new All_tools_Form_Apps.Form11();
                o.Show();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void browser_Click(object sender, EventArgs e)
        {
            if (Program.browser_ok)
            {
                Form o = new Form12();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void number_picker_Click(object sender, EventArgs e)
        {
            if (Program.number_picker_ok)
            {
                var o = new All_tools_Form_Apps.Form13();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void MusicPlayer_Click(object sender, EventArgs e)
        {
            if (Program.media_player_ok)
            {
                var o = new All_tools_Form_Apps.Form14();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "GEOMETRICGAME   " + DateTime.Now.Hour + ":" +
                DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void youtubeDownloader_Click(object sender, EventArgs e)
        {
            if (Program.youtube_downloader_ok)
            {
                var o = new All_tools_Form_Apps.Form15();
                o.ShowDialog();
            }
            else
            {
                Program.show_msgbox("此功能已被禁用", "抱歉，這個功能已被停用" +
                    "，請至 [應用選項] 開啟此功能。", "Error", "OK");
            }
        }

        Boolean app_onoff_opened = false;
        private void app_onoff_settings_Click(object sender, EventArgs e)
        {
            var open = new All_tools_Form_Apps.Setting.App_onoff_password();
            open.ShowDialog();
        }

        private void large_filename_changer_Click(object sender, EventArgs e)
        {
            var open = new Form17();
            open.ShowDialog();
        }

        private void file_Downloader_Click(object sender, EventArgs e)
        {
            var open = new Form18();
            open.ShowDialog();
        }

        private void english()
        {
            lasttool.Text = "Msgbox generator";
            open_computer.Text = "calculator";
            PlayGames.Text = "Play games NOW!";
            shutdown.Text = "Shutdown timer";
            open_clicker.Text = "Cursor Recorder";
            Task_Manager.Text = "Notepad+";
            send_email.Text = "Send Email";
            cattest.Text = "Scoring system";
            svesystem.Text = "service system";
            Alarm.Text = "Alarm clock";
            Clock.Text = "Clock";
            browser.Text = "Web browser";
            number_picker.Text = "Number picker";
            MusicPlayer.Text = "Media player";
            youtubeDownloader.Text = "Youtube Downloader";
            large_filename_changer.Text = "File renamer";
            file_Downloader.Text = "FTP file downloader";
            app_onoff_settings.Text = "Feature settings";
            open_setting.Text = "Restart to adv opt";
        }

        private void chinese()
        {
            lasttool.Text = "彈出視窗產生器";
            open_computer.Text = "計算機";
            PlayGames.Text = "立刻玩遊戲";
            shutdown.Text = "排程關機或重新啟動";
            open_clicker.Text = "游標錄製器";
            Task_Manager.Text = "文字編輯器";
            send_email.Text = "寄送 Email";
            cattest.Text = "評分系統";
            svesystem.Text = "服務系統";
            Alarm.Text = "鬧鐘";
            Clock.Text = "時鐘";
            browser.Text = "瀏覽器";
            number_picker.Text = "選號器";
            MusicPlayer.Text = "媒體播放器";
            youtubeDownloader.Text = "Youtube 影片下載器";
            large_filename_changer.Text = "批量檔案改名器";
            file_Downloader.Text = "檔案下載器";
            app_onoff_settings.Text = "應用設定";
            open_setting.Text = "重啟至進階選項";
        }

        private void lang_Click(object sender, EventArgs e)
        {
            if (lang.Text == "English")
            {
                english();
                lang.Text = "繁體中文";
            }
            else
            {
                chinese();
                lang.Text = "English";
            }
        }

        private async void set_background_pic_Click(object sender, EventArgs e)
        {
            right_click_menu.Visible = false;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "圖像檔案 (*.gif;*.png;*.jpg;*.jpeg;*.bmp;*.wmf)|*.gif;*.png;*.jpg;*.jpeg;*.bmp;*.wmf";
            ofd.Title = "選擇一個圖像當作桌面";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BGI.Image = Image.FromFile(ofd.FileName);
                    BGI.Visible = true;
                }
                catch (Exception ex)
                {
                    Program.show_notify("Geometricgame Apps", "套用圖檔時發生錯誤，請再試一次。 如果這種情況重複發生，請換一張圖檔。", 2500, "error", false);
                }
                BGI.Size = new Size(this.Width, this.Height - ColorBox1.Height);
                BGI.Location = new Point(0, ColorBox1.Height);
            }
            else
            {
                BGI.Visible = false;
            }
        }

        private void logoff_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("C:\\GeometricgamesApps\\using\\stay_login.gss");
            }
            catch { }

            this.Close();
        }

        private async void daytimes()
        {
            while (true)
            {

                string h0 = "";
                string m0 = "";
                string s0 = "";
                string o0 = "";
                string d0 = "";

                DateTime dt = DateTime.Now;

                if (dt.Hour > 12)
                {
                    if ((dt.Hour - 12).ToString().Length < 2)
                    {
                        h0 = "0";
                    }
                }
                else
                {
                    if (dt.Hour.ToString().Length < 2)
                    {
                        h0 = "0";
                    }
                }
                if (dt.Minute.ToString().Length < 2)
                {
                    m0 = "0";
                }
                if (dt.Second.ToString().Length < 2)
                {
                    s0 = "0";
                }
                if (dt.Month.ToString().Length < 2)
                {
                    o0 = "0";
                }
                if (dt.Day.ToString().Length < 2)
                {
                    d0 = "0";
                }

                if (dt.Hour < 12)
                {
                    daytime.Text = "上午 " + h0 + dt.Hour + ":" + m0 + dt.Minute + ":" + s0 + dt.Second;
                }
                else if (dt.Hour == 12)
                {
                    daytime.Text = "中午 " + h0 + dt.Hour + ":" + m0 + dt.Minute + ":" + s0 + dt.Second;
                }
                else if (dt.Hour > 12)
                {
                    daytime.Text = "下午 " + h0 + ((int)dt.Hour - 12) + ":" + m0 + dt.Minute + ":" + s0 + dt.Second;
                }

                daytime.Text += "\n" + dt.Year + "/" + o0 + dt.Month + "/" + d0 + dt.Day;

                await Task.Delay(1000);
            }
        }

        private async void taskbaraction()
        {
            taskBar.Visible = true;
            taskBar.Location = new Point(-6, this.Height);

            SoundPlayer sound = new SoundPlayer(All_tools_Form_Apps.Properties.Resources.Windows11_startup);
            sound.Play();

            if (File.Exists("C:\\GeometricgamesApps\\using\\start_video.gof"))
            {
                await Task.Delay(250);

                for (int i = 0; i < taskBar.Height - 3; i += 3)
                {
                    taskBar.Location = new Point(-6, this.Height - i);
                    await Task.Delay(1);
                }
            }
            else
            {
                await Task.Delay(250);

                for (int i = 0; i < taskBar.Height - 3; i += 3)
                {
                    taskBar.Location = new Point(-6, this.Height - i);
                }
            }
        }

        private void minecraft_hack_Click(object sender, EventArgs e)
        {
            new minecraft_hack().ShowDialog();
        }

        private async void opa_in()
        {
            if (File.Exists("C:\\GeometricgamesApps\\using\\start_video.gof"))
            {
                this.Opacity = 0;
                for (int i = 0; i < 50; i++)
                {
                    this.Opacity += 0.02;
                    await Task.Delay(10);
                }
            }

            taskbaraction();
        }

        private async void opa_out()
        {
            this.Opacity = 1;
            for (int i = 0; i < 50; i++)
            {
                this.Opacity -= 0.02;
                await Task.Delay(10);
            }

            qc = true;
            new shutdown_app("shutdown", 0, 0).ShowDialog();
            this.Close();
        }

        private void up_computeer_Click(object sender, EventArgs e)
        {
            new Form16().ShowDialog();
        }

        private void fileInfoReader_Click(object sender, EventArgs e)
        {
            new Form19().ShowDialog();
        }

        private void screen_control_Click(object sender, EventArgs e)
        {
            new Form20().ShowDialog();
        }

        private void explorer_Click(object sender, EventArgs e)
        {
            new All_tools_Form_Apps.MessageBoxs.single_download(new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1ZJu0JNSr_W_-eqFVbjzFUhvIOpqyXMIy&export=download", "file_explorer.exe"), "檔案總管").ShowDialog();
            new Form21().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            qc = true;
            Form shutdown = new shutdown_app("restart", 0, 0);
            shutdown.Show();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                right_click_menu.Location = MousePosition;
                right_click_menu.Visible = true;
                right_click_menu.BringToFront();
                right_click_menu_runded.CornerRadius = 25;
            }
            else
            {
                right_click_menu.Visible = false;
            }
        }

        private void downloads_area_Click(object sender, EventArgs e)
        {
            new All_tools_Form_Apps.External_res.main().ShowDialog();
        }

        private void right_close_menu_Click(object sender, EventArgs e)
        {
            right_click_menu.Visible = false;
        }

        private void right_personal_settings_Click(object sender, EventArgs e)
        {
            new personal_settings().ShowDialog();
            right_click_menu.Visible = false;
        }

        int right_click_menu_leave_counter = 0;
        Boolean right_click_menu_enter = true;
        private async void right_click_menu_Leave(object sender, EventArgs e)
        {
            right_click_menu_enter = false;
            right_click_menu_leave_counter = 0;
            while (right_click_menu_enter == false)
            {
                await Task.Delay(1000);
                right_click_menu_leave_counter++;

                if (right_click_menu_leave_counter > 3)
                {
                    right_click_menu.Visible = false;
                    break;
                }
            }
        }

        private void right_click_menu_Enter(object sender, EventArgs e)
        {
            right_click_menu_leave_counter = 0;
            right_click_menu_enter = true;
        }

        int nowpage = 1;
        private void before_page_Click(object sender, EventArgs e)
        {
            nowpage--;
            show_taskpage(nowpage);
        }

        private void next_page_Click(object sender, EventArgs e)
        {
            nowpage++;
            show_taskpage(nowpage);
        }

        private void show_taskpage(int page)
        {
            before_page.Enabled = true;
            next_page.Enabled = true;
            List<Panel> pages = new List<Panel> { toolpage1, toolpage2 };
            for (int i = 0; i < pages.Count(); i++)
            {
                pages[i].Visible = false;
            }

            pages[page - 1].Visible = true;

            if (page == 1)
            {
                before_page.Enabled = false;
            }
            if (page == pages.Count())
            {
                next_page.Enabled = false;
            }
        }

        private async void minimize_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();

            for (int i = 0; i < this.Height / 75; i++)
            {
                this.Location = new Point(0, this.Location.Y + 75);
                await Task.Delay(1);
            }

            this.WindowState = FormWindowState.Minimized;
            this.Location = new Point(0, 0);
        }

        private async void Form2_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && this.Location != new Point(0, 0))
            {
                this.ResumeLayout();

                this.WindowState = FormWindowState.Normal;
                await Task.Delay(10);
                this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height);

                for (int i = 0; i < this.Height / 75; i++)
                {
                    this.Location = new Point(0, this.Location.Y - 75);
                    await Task.Delay(1);
                }

                this.Location = new Point(0, 0);
            }
        }

        private void tomato_clock_Click(object sender, EventArgs e)
        {
            new Form22().ShowDialog();
        }
    }
}
