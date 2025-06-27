using All_tools_Form_Apps.Custom_class;

namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            open_computer = new Button();
            lasttool = new Button();
            shutdown = new Button();
            open_clicker = new Button();
            open_setting = new Button();
            Task_Manager = new Button();
            PlayGames = new Button();
            send_email = new Button();
            BigTitle = new Label();
            ColorBox1 = new Label();
            cattest = new Button();
            svesystem = new Button();
            Alarm = new Button();
            Clock = new Button();
            browser = new Button();
            number_picker = new Button();
            MusicPlayer = new Button();
            version = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            youtubeDownloader = new Button();
            app_onoff_settings = new Button();
            large_filename_changer = new Button();
            file_Downloader = new Button();
            lang = new Button();
            set_background_pic = new Button();
            BGI = new PictureBox();
            daytime = new Label();
            taskBar = new GroupBox();
            next_page = new Button();
            before_page = new Button();
            toolpage1 = new Panel();
            toolpage2 = new Panel();
            downloads_area = new Button();
            screen_control = new Button();
            fileInfoReader = new Button();
            minecraft_hack = new Button();
            up_computeer = new Button();
            explorer = new Button();
            windows_version_w = new Label();
            right_click_menu = new GroupBox();
            right_close_menu = new Button();
            right_personal_settings = new Button();
            right_click_menu_runded = new EllipseContorl();
            pictureBox1 = new Button();
            logout = new Button();
            Close_Form = new Button();
            sub_title = new Label();
            minimize = new Button();
            tomato_clock = new Button();
            ((System.ComponentModel.ISupportInitialize)BGI).BeginInit();
            taskBar.SuspendLayout();
            toolpage1.SuspendLayout();
            toolpage2.SuspendLayout();
            right_click_menu.SuspendLayout();
            SuspendLayout();
            // 
            // open_computer
            // 
            open_computer.FlatStyle = FlatStyle.System;
            open_computer.Location = new Point(4, 4);
            open_computer.Margin = new Padding(4);
            open_computer.Name = "open_computer";
            open_computer.Size = new Size(138, 45);
            open_computer.TabIndex = 2;
            open_computer.Text = "計算機";
            open_computer.UseVisualStyleBackColor = true;
            open_computer.Click += open_computer_Click;
            // 
            // lasttool
            // 
            lasttool.FlatStyle = FlatStyle.System;
            lasttool.Location = new Point(534, 4);
            lasttool.Margin = new Padding(4);
            lasttool.Name = "lasttool";
            lasttool.Size = new Size(200, 45);
            lasttool.TabIndex = 4;
            lasttool.Text = "彈出視窗產生器";
            lasttool.UseVisualStyleBackColor = true;
            lasttool.Click += lasttool_Click;
            // 
            // shutdown
            // 
            shutdown.FlatStyle = FlatStyle.System;
            shutdown.Location = new Point(149, 4);
            shutdown.Margin = new Padding(4);
            shutdown.Name = "shutdown";
            shutdown.Size = new Size(233, 45);
            shutdown.TabIndex = 5;
            shutdown.Text = "排程關機或重新啟動\r\n";
            shutdown.UseVisualStyleBackColor = true;
            shutdown.Click += shutdown_Click;
            // 
            // open_clicker
            // 
            open_clicker.FlatStyle = FlatStyle.System;
            open_clicker.Location = new Point(388, 4);
            open_clicker.Margin = new Padding(4);
            open_clicker.Name = "open_clicker";
            open_clicker.Size = new Size(138, 45);
            open_clicker.TabIndex = 6;
            open_clicker.Text = "游標錄製器";
            open_clicker.UseVisualStyleBackColor = true;
            open_clicker.Click += open_clicker_Click;
            // 
            // open_setting
            // 
            open_setting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            open_setting.FlatStyle = FlatStyle.System;
            open_setting.ForeColor = SystemColors.ControlText;
            open_setting.Location = new Point(1586, 67);
            open_setting.Margin = new Padding(4);
            open_setting.Name = "open_setting";
            open_setting.Size = new Size(235, 48);
            open_setting.TabIndex = 8;
            open_setting.Text = "重啟至進階選項";
            open_setting.UseVisualStyleBackColor = true;
            open_setting.Click += open_setting_Click;
            // 
            // Task_Manager
            // 
            Task_Manager.FlatStyle = FlatStyle.System;
            Task_Manager.Location = new Point(741, 4);
            Task_Manager.Margin = new Padding(4);
            Task_Manager.Name = "Task_Manager";
            Task_Manager.Size = new Size(133, 45);
            Task_Manager.TabIndex = 9;
            Task_Manager.Text = "文字編輯器";
            Task_Manager.UseVisualStyleBackColor = true;
            Task_Manager.Click += Task_Manager_Click;
            // 
            // PlayGames
            // 
            PlayGames.BackColor = SystemColors.Control;
            PlayGames.FlatStyle = FlatStyle.System;
            PlayGames.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            PlayGames.ForeColor = SystemColors.ControlText;
            PlayGames.Location = new Point(488, 4);
            PlayGames.Margin = new Padding(4);
            PlayGames.Name = "PlayGames";
            PlayGames.Size = new Size(956, 44);
            PlayGames.TabIndex = 13;
            PlayGames.Text = "立刻玩遊戲!";
            PlayGames.UseVisualStyleBackColor = false;
            PlayGames.Click += PlayGames_Click;
            // 
            // send_email
            // 
            send_email.FlatStyle = FlatStyle.System;
            send_email.Location = new Point(880, 4);
            send_email.Margin = new Padding(4);
            send_email.Name = "send_email";
            send_email.Size = new Size(133, 45);
            send_email.TabIndex = 14;
            send_email.Text = "寄送 Email";
            send_email.UseVisualStyleBackColor = true;
            send_email.Click += send_email_Click;
            // 
            // BigTitle
            // 
            BigTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BigTitle.Font = new Font("Minecraft Ten v2", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BigTitle.ForeColor = Color.FromArgb(83, 87, 237);
            BigTitle.Location = new Point(13, 119);
            BigTitle.Margin = new Padding(4, 0, 4, 0);
            BigTitle.Name = "BigTitle";
            BigTitle.Size = new Size(1798, 205);
            BigTitle.TabIndex = 15;
            BigTitle.Text = "GEOMETRICGAMES";
            BigTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ColorBox1
            // 
            ColorBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ColorBox1.BackColor = Color.FromArgb(247, 204, 10);
            ColorBox1.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ColorBox1.ForeColor = Color.FromArgb(106, 8, 219);
            ColorBox1.Location = new Point(-4, -1);
            ColorBox1.Margin = new Padding(4, 0, 4, 0);
            ColorBox1.Name = "ColorBox1";
            ColorBox1.Size = new Size(1834, 62);
            ColorBox1.TabIndex = 17;
            ColorBox1.Text = "GEOMETRICGAMES MENU";
            ColorBox1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cattest
            // 
            cattest.FlatStyle = FlatStyle.System;
            cattest.Location = new Point(1020, 4);
            cattest.Margin = new Padding(4);
            cattest.Name = "cattest";
            cattest.Size = new Size(133, 45);
            cattest.TabIndex = 20;
            cattest.Text = "評分系統";
            cattest.UseVisualStyleBackColor = true;
            cattest.Click += cattest_Click;
            // 
            // svesystem
            // 
            svesystem.FlatStyle = FlatStyle.System;
            svesystem.Location = new Point(1159, 4);
            svesystem.Margin = new Padding(4);
            svesystem.Name = "svesystem";
            svesystem.Size = new Size(133, 45);
            svesystem.TabIndex = 21;
            svesystem.Text = "服務系統";
            svesystem.UseVisualStyleBackColor = true;
            svesystem.Click += svesystem_Click;
            // 
            // Alarm
            // 
            Alarm.FlatStyle = FlatStyle.System;
            Alarm.Location = new Point(880, 57);
            Alarm.Margin = new Padding(4);
            Alarm.Name = "Alarm";
            Alarm.Size = new Size(133, 45);
            Alarm.TabIndex = 22;
            Alarm.Text = "鬧鐘";
            Alarm.UseVisualStyleBackColor = true;
            Alarm.Click += Alarm_Click;
            // 
            // Clock
            // 
            Clock.FlatStyle = FlatStyle.System;
            Clock.Location = new Point(1020, 57);
            Clock.Margin = new Padding(4);
            Clock.Name = "Clock";
            Clock.Size = new Size(133, 45);
            Clock.TabIndex = 23;
            Clock.Text = "時鐘";
            Clock.UseVisualStyleBackColor = true;
            Clock.Click += Clock_Click;
            // 
            // browser
            // 
            browser.FlatStyle = FlatStyle.System;
            browser.Location = new Point(1159, 57);
            browser.Margin = new Padding(4);
            browser.Name = "browser";
            browser.Size = new Size(133, 45);
            browser.TabIndex = 24;
            browser.Text = "瀏覽器";
            browser.UseVisualStyleBackColor = true;
            browser.Click += browser_Click;
            // 
            // number_picker
            // 
            number_picker.FlatStyle = FlatStyle.System;
            number_picker.Location = new Point(4, 58);
            number_picker.Margin = new Padding(4);
            number_picker.Name = "number_picker";
            number_picker.Size = new Size(133, 45);
            number_picker.TabIndex = 25;
            number_picker.Text = "選號器";
            number_picker.UseVisualStyleBackColor = true;
            number_picker.Click += number_picker_Click;
            // 
            // MusicPlayer
            // 
            MusicPlayer.FlatStyle = FlatStyle.System;
            MusicPlayer.Location = new Point(143, 57);
            MusicPlayer.Margin = new Padding(4);
            MusicPlayer.Name = "MusicPlayer";
            MusicPlayer.Size = new Size(138, 47);
            MusicPlayer.TabIndex = 26;
            MusicPlayer.Text = "媒體播放器";
            MusicPlayer.UseVisualStyleBackColor = true;
            MusicPlayer.Click += MusicPlayer_Click;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Font = new Font("Mojangles", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            version.Location = new Point(6, 67);
            version.Margin = new Padding(4, 0, 4, 0);
            version.Name = "version";
            version.Size = new Size(274, 25);
            version.TabIndex = 27;
            version.Text = "Geometricgames version";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // youtubeDownloader
            // 
            youtubeDownloader.FlatStyle = FlatStyle.System;
            youtubeDownloader.Location = new Point(288, 57);
            youtubeDownloader.Margin = new Padding(4);
            youtubeDownloader.Name = "youtubeDownloader";
            youtubeDownloader.Size = new Size(233, 47);
            youtubeDownloader.TabIndex = 28;
            youtubeDownloader.Text = "Youtube 影片下載器";
            youtubeDownloader.UseVisualStyleBackColor = true;
            youtubeDownloader.Click += youtubeDownloader_Click;
            // 
            // app_onoff_settings
            // 
            app_onoff_settings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            app_onoff_settings.FlatStyle = FlatStyle.System;
            app_onoff_settings.ForeColor = SystemColors.ControlText;
            app_onoff_settings.Location = new Point(1343, 68);
            app_onoff_settings.Margin = new Padding(4);
            app_onoff_settings.Name = "app_onoff_settings";
            app_onoff_settings.Size = new Size(235, 48);
            app_onoff_settings.TabIndex = 29;
            app_onoff_settings.Text = "應用選項";
            app_onoff_settings.UseVisualStyleBackColor = true;
            app_onoff_settings.Click += app_onoff_settings_Click;
            // 
            // large_filename_changer
            // 
            large_filename_changer.FlatStyle = FlatStyle.System;
            large_filename_changer.Location = new Point(528, 57);
            large_filename_changer.Margin = new Padding(4);
            large_filename_changer.Name = "large_filename_changer";
            large_filename_changer.Size = new Size(199, 47);
            large_filename_changer.TabIndex = 30;
            large_filename_changer.Text = "批量檔案改名器";
            large_filename_changer.UseVisualStyleBackColor = true;
            large_filename_changer.Click += large_filename_changer_Click;
            // 
            // file_Downloader
            // 
            file_Downloader.FlatStyle = FlatStyle.System;
            file_Downloader.Location = new Point(734, 57);
            file_Downloader.Margin = new Padding(4);
            file_Downloader.Name = "file_Downloader";
            file_Downloader.Size = new Size(139, 47);
            file_Downloader.TabIndex = 31;
            file_Downloader.Text = "檔案下載器";
            file_Downloader.UseVisualStyleBackColor = true;
            file_Downloader.Click += file_Downloader_Click;
            // 
            // lang
            // 
            lang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lang.FlatStyle = FlatStyle.System;
            lang.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lang.ForeColor = SystemColors.ControlText;
            lang.Location = new Point(1100, 68);
            lang.Margin = new Padding(4);
            lang.Name = "lang";
            lang.Size = new Size(235, 48);
            lang.TabIndex = 32;
            lang.Text = "English";
            lang.UseVisualStyleBackColor = true;
            lang.Click += lang_Click;
            // 
            // set_background_pic
            // 
            set_background_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            set_background_pic.FlatStyle = FlatStyle.Flat;
            set_background_pic.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            set_background_pic.ForeColor = SystemColors.ControlText;
            set_background_pic.Location = new Point(7, 86);
            set_background_pic.Margin = new Padding(4);
            set_background_pic.Name = "set_background_pic";
            set_background_pic.Size = new Size(277, 48);
            set_background_pic.TabIndex = 33;
            set_background_pic.Text = "設定桌面圖片 (&B)";
            set_background_pic.UseVisualStyleBackColor = true;
            set_background_pic.Click += set_background_pic_Click;
            // 
            // BGI
            // 
            BGI.Location = new Point(-1, -1);
            BGI.Margin = new Padding(4);
            BGI.Name = "BGI";
            BGI.Size = new Size(341, 205);
            BGI.SizeMode = PictureBoxSizeMode.Zoom;
            BGI.TabIndex = 34;
            BGI.TabStop = false;
            BGI.Visible = false;
            // 
            // daytime
            // 
            daytime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            daytime.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            daytime.Location = new Point(1628, 32);
            daytime.Margin = new Padding(4, 0, 4, 0);
            daytime.Name = "daytime";
            daytime.Size = new Size(201, 104);
            daytime.TabIndex = 36;
            daytime.Text = "時間";
            daytime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskBar
            // 
            taskBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            taskBar.Controls.Add(next_page);
            taskBar.Controls.Add(before_page);
            taskBar.Controls.Add(daytime);
            taskBar.Controls.Add(toolpage2);
            taskBar.Controls.Add(toolpage1);
            taskBar.FlatStyle = FlatStyle.Flat;
            taskBar.ForeColor = SystemColors.ControlLightLight;
            taskBar.Location = new Point(-8, 709);
            taskBar.Margin = new Padding(4);
            taskBar.Name = "taskBar";
            taskBar.Padding = new Padding(4);
            taskBar.Size = new Size(2098, 155);
            taskBar.TabIndex = 37;
            taskBar.TabStop = false;
            taskBar.UseCompatibleTextRendering = true;
            taskBar.Visible = false;
            // 
            // next_page
            // 
            next_page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            next_page.FlatStyle = FlatStyle.System;
            next_page.Location = new Point(1487, 83);
            next_page.Name = "next_page";
            next_page.Size = new Size(134, 53);
            next_page.TabIndex = 51;
            next_page.Text = "▼ 下一頁";
            next_page.UseVisualStyleBackColor = true;
            next_page.Click += next_page_Click;
            // 
            // before_page
            // 
            before_page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            before_page.Enabled = false;
            before_page.FlatStyle = FlatStyle.System;
            before_page.Location = new Point(1487, 25);
            before_page.Name = "before_page";
            before_page.Size = new Size(134, 48);
            before_page.TabIndex = 48;
            before_page.Text = "▲ 上一頁";
            before_page.UseVisualStyleBackColor = true;
            before_page.Click += before_page_Click;
            // 
            // toolpage1
            // 
            toolpage1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolpage1.Controls.Add(open_computer);
            toolpage1.Controls.Add(send_email);
            toolpage1.Controls.Add(large_filename_changer);
            toolpage1.Controls.Add(file_Downloader);
            toolpage1.Controls.Add(cattest);
            toolpage1.Controls.Add(svesystem);
            toolpage1.Controls.Add(number_picker);
            toolpage1.Controls.Add(Task_Manager);
            toolpage1.Controls.Add(lasttool);
            toolpage1.Controls.Add(youtubeDownloader);
            toolpage1.Controls.Add(browser);
            toolpage1.Controls.Add(Alarm);
            toolpage1.Controls.Add(shutdown);
            toolpage1.Controls.Add(open_clicker);
            toolpage1.Controls.Add(Clock);
            toolpage1.Controls.Add(MusicPlayer);
            toolpage1.Location = new Point(15, 25);
            toolpage1.Name = "toolpage1";
            toolpage1.Size = new Size(1466, 113);
            toolpage1.TabIndex = 48;
            toolpage1.Visible = false;
            // 
            // toolpage2
            // 
            toolpage2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolpage2.Controls.Add(tomato_clock);
            toolpage2.Controls.Add(downloads_area);
            toolpage2.Controls.Add(screen_control);
            toolpage2.Controls.Add(PlayGames);
            toolpage2.Controls.Add(fileInfoReader);
            toolpage2.Controls.Add(minecraft_hack);
            toolpage2.Controls.Add(up_computeer);
            toolpage2.Location = new Point(14, 25);
            toolpage2.Name = "toolpage2";
            toolpage2.Size = new Size(1456, 111);
            toolpage2.TabIndex = 50;
            toolpage2.Visible = false;
            // 
            // downloads_area
            // 
            downloads_area.BackColor = SystemColors.Control;
            downloads_area.FlatStyle = FlatStyle.System;
            downloads_area.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            downloads_area.ForeColor = SystemColors.ControlText;
            downloads_area.Location = new Point(488, 56);
            downloads_area.Margin = new Padding(4);
            downloads_area.Name = "downloads_area";
            downloads_area.Size = new Size(956, 45);
            downloads_area.TabIndex = 41;
            downloads_area.Text = "下載專區";
            downloads_area.UseVisualStyleBackColor = false;
            downloads_area.Click += downloads_area_Click;
            // 
            // screen_control
            // 
            screen_control.FlatStyle = FlatStyle.System;
            screen_control.Location = new Point(143, 56);
            screen_control.Margin = new Padding(4);
            screen_control.Name = "screen_control";
            screen_control.Size = new Size(196, 45);
            screen_control.TabIndex = 40;
            screen_control.Text = "螢幕控制器";
            screen_control.UseVisualStyleBackColor = true;
            screen_control.Click += screen_control_Click;
            // 
            // fileInfoReader
            // 
            fileInfoReader.FlatStyle = FlatStyle.System;
            fileInfoReader.Location = new Point(143, 4);
            fileInfoReader.Margin = new Padding(4);
            fileInfoReader.Name = "fileInfoReader";
            fileInfoReader.Size = new Size(196, 45);
            fileInfoReader.TabIndex = 39;
            fileInfoReader.Text = "檔案資訊讀取頁面";
            fileInfoReader.UseVisualStyleBackColor = true;
            fileInfoReader.Click += fileInfoReader_Click;
            // 
            // minecraft_hack
            // 
            minecraft_hack.FlatStyle = FlatStyle.System;
            minecraft_hack.Location = new Point(4, 4);
            minecraft_hack.Margin = new Padding(4);
            minecraft_hack.Name = "minecraft_hack";
            minecraft_hack.Size = new Size(133, 45);
            minecraft_hack.TabIndex = 37;
            minecraft_hack.Text = "MC 外掛";
            minecraft_hack.UseVisualStyleBackColor = true;
            minecraft_hack.Click += minecraft_hack_Click;
            // 
            // up_computeer
            // 
            up_computeer.FlatStyle = FlatStyle.System;
            up_computeer.Location = new Point(4, 57);
            up_computeer.Margin = new Padding(4);
            up_computeer.Name = "up_computeer";
            up_computeer.Size = new Size(133, 45);
            up_computeer.TabIndex = 38;
            up_computeer.Text = "進階計算機";
            up_computeer.UseVisualStyleBackColor = true;
            up_computeer.Click += up_computeer_Click;
            // 
            // explorer
            // 
            explorer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            explorer.FlatStyle = FlatStyle.System;
            explorer.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            explorer.Location = new Point(936, 68);
            explorer.Margin = new Padding(4);
            explorer.Name = "explorer";
            explorer.Size = new Size(156, 47);
            explorer.TabIndex = 41;
            explorer.Text = "檔案總管";
            explorer.UseVisualStyleBackColor = true;
            explorer.Click += explorer_Click;
            // 
            // windows_version_w
            // 
            windows_version_w.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            windows_version_w.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            windows_version_w.ForeColor = Color.Red;
            windows_version_w.Location = new Point(1125, 646);
            windows_version_w.Margin = new Padding(4, 0, 4, 0);
            windows_version_w.Name = "windows_version_w";
            windows_version_w.Size = new Size(686, 65);
            windows_version_w.TabIndex = 43;
            windows_version_w.Text = "Windows 版本不在支援範圍內，可能效果不如預期。 作業系統Build碼: ";
            windows_version_w.TextAlign = ContentAlignment.BottomRight;
            windows_version_w.Visible = false;
            // 
            // right_click_menu
            // 
            right_click_menu.BackColor = Color.White;
            right_click_menu.Controls.Add(right_close_menu);
            right_click_menu.Controls.Add(right_personal_settings);
            right_click_menu.Controls.Add(set_background_pic);
            right_click_menu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            right_click_menu.ForeColor = SystemColors.ControlText;
            right_click_menu.Location = new Point(-1, 211);
            right_click_menu.Name = "right_click_menu";
            right_click_menu.Size = new Size(291, 206);
            right_click_menu.TabIndex = 44;
            right_click_menu.TabStop = false;
            right_click_menu.Text = "更多選項";
            right_click_menu.Visible = false;
            right_click_menu.Enter += right_click_menu_Enter;
            right_click_menu.Leave += right_click_menu_Leave;
            // 
            // right_close_menu
            // 
            right_close_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            right_close_menu.FlatAppearance.BorderSize = 2;
            right_close_menu.FlatStyle = FlatStyle.Flat;
            right_close_menu.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            right_close_menu.Location = new Point(6, 158);
            right_close_menu.Name = "right_close_menu";
            right_close_menu.Size = new Size(279, 42);
            right_close_menu.TabIndex = 1;
            right_close_menu.Text = "關閉選單 (&C)";
            right_close_menu.UseVisualStyleBackColor = true;
            right_close_menu.Click += right_close_menu_Click;
            // 
            // right_personal_settings
            // 
            right_personal_settings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            right_personal_settings.FlatStyle = FlatStyle.Flat;
            right_personal_settings.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            right_personal_settings.Location = new Point(6, 37);
            right_personal_settings.Name = "right_personal_settings";
            right_personal_settings.Size = new Size(279, 42);
            right_personal_settings.TabIndex = 0;
            right_personal_settings.Text = "個人化設定 (&P)";
            right_personal_settings.UseVisualStyleBackColor = true;
            right_personal_settings.Click += right_personal_settings_Click;
            // 
            // right_click_menu_runded
            // 
            right_click_menu_runded.CornerRadius = 25;
            right_click_menu_runded.TargetControl = right_click_menu;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(247, 174, 10);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.FlatAppearance.BorderSize = 0;
            pictureBox1.FlatStyle = FlatStyle.Flat;
            pictureBox1.Location = new Point(1611, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 61);
            pictureBox1.TabIndex = 45;
            pictureBox1.UseVisualStyleBackColor = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.BackColor = Color.FromArgb(247, 174, 10);
            logout.BackgroundImage = (Image)resources.GetObject("logout.BackgroundImage");
            logout.BackgroundImageLayout = ImageLayout.Zoom;
            logout.Cursor = Cursors.Hand;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Location = new Point(1683, -1);
            logout.Name = "logout";
            logout.Size = new Size(73, 61);
            logout.TabIndex = 46;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logoff_Click;
            // 
            // Close_Form
            // 
            Close_Form.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close_Form.BackColor = Color.FromArgb(247, 174, 10);
            Close_Form.BackgroundImage = (Image)resources.GetObject("Close_Form.BackgroundImage");
            Close_Form.BackgroundImageLayout = ImageLayout.Zoom;
            Close_Form.Cursor = Cursors.Hand;
            Close_Form.FlatAppearance.BorderSize = 0;
            Close_Form.FlatStyle = FlatStyle.Flat;
            Close_Form.Location = new Point(1753, -1);
            Close_Form.Name = "Close_Form";
            Close_Form.Size = new Size(73, 61);
            Close_Form.TabIndex = 47;
            Close_Form.UseVisualStyleBackColor = false;
            Close_Form.Click += Close_Form_Click;
            // 
            // sub_title
            // 
            sub_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sub_title.Font = new Font("Poppins SemiBold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sub_title.ForeColor = Color.White;
            sub_title.Location = new Point(13, 393);
            sub_title.Margin = new Padding(4, 0, 4, 0);
            sub_title.Name = "sub_title";
            sub_title.Size = new Size(1800, 127);
            sub_title.TabIndex = 16;
            sub_title.Text = "title.subtitle.text";
            sub_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.BackColor = Color.FromArgb(247, 174, 10);
            minimize.BackgroundImage = (Image)resources.GetObject("minimize.BackgroundImage");
            minimize.BackgroundImageLayout = ImageLayout.Zoom;
            minimize.Cursor = Cursors.Hand;
            minimize.FlatAppearance.BorderSize = 0;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Location = new Point(1538, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(73, 61);
            minimize.TabIndex = 48;
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += minimize_Click;
            // 
            // tomato_clock
            // 
            tomato_clock.FlatStyle = FlatStyle.System;
            tomato_clock.Location = new Point(347, 4);
            tomato_clock.Margin = new Padding(4);
            tomato_clock.Name = "tomato_clock";
            tomato_clock.Size = new Size(133, 45);
            tomato_clock.TabIndex = 42;
            tomato_clock.Text = "番茄鐘";
            tomato_clock.UseVisualStyleBackColor = true;
            tomato_clock.Click += tomato_clock_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1826, 866);
            ControlBox = false;
            Controls.Add(minimize);
            Controls.Add(Close_Form);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Controls.Add(right_click_menu);
            Controls.Add(windows_version_w);
            Controls.Add(explorer);
            Controls.Add(taskBar);
            Controls.Add(lang);
            Controls.Add(app_onoff_settings);
            Controls.Add(open_setting);
            Controls.Add(version);
            Controls.Add(ColorBox1);
            Controls.Add(BGI);
            Controls.Add(BigTitle);
            Controls.Add(sub_title);
            Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Opacity = 0D;
            StartPosition = FormStartPosition.Manual;
            Text = "Geomrtricgame Apps";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            SizeChanged += Form2_SizeChanged;
            MouseClick += Form2_MouseClick;
            ((System.ComponentModel.ISupportInitialize)BGI).EndInit();
            taskBar.ResumeLayout(false);
            toolpage1.ResumeLayout(false);
            toolpage2.ResumeLayout(false);
            right_click_menu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button open_computer;
        private Button lasttool;
        private Button shutdown;
        private Button open_clicker;
        private Button open_setting;
        private Button Task_Manager;
        private Button PlayGames;
        private Button send_email;
        private Label BigTitle;
        private Label ColorBox1;
        private Button cattest;
        private Button svesystem;
        private Button Alarm;
        private Button Clock;
        private EllipseContorl ellipseContorl1;
        private Button browser;
        private Button number_picker;
        private Button MusicPlayer;
        private Label version;
        private System.Windows.Forms.Timer timer1;
        private Button youtubeDownloader;
        private Button app_onoff_settings;
        private Button large_filename_changer;
        private Button file_Downloader;
        private Button lang;
        private Button set_background_pic;
        private PictureBox BGI;
        private Label daytime;
        private GroupBox taskBar;
        private Button minecraft_hack;
        private Button up_computeer;
        private Button fileInfoReader;
        private Button screen_control;
        private Button explorer;
        private Label windows_version_w;
        private Button downloads_area;
        private GroupBox right_click_menu;
        private Button right_personal_settings;
        private Button right_close_menu;
        private EllipseContorl right_click_menu_runded;
        private Button pictureBox1;
        private Button logout;
        private Button Close_Form;
        private Label sub_title;
        private Panel toolpage1;
        private Panel toolpage2;
        private Button before_page;
        private Button next_page;
        private Button minimize;
        private Button tomato_clock;
    }
}