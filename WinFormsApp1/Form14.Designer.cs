namespace All_tools_Form_Apps
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            PlayList = new ListBox();
            fileName = new Label();
            lblDuration = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            chooseFolder = new Button();
            pause = new Button();
            stop = new Button();
            fullscreen = new Button();
            exit_fullscreen = new Button();
            ellipseContorl2 = new Custom_class.EllipseContorl();
            ellipseContorl1 = new Custom_class.EllipseContorl();
            ((System.ComponentModel.ISupportInitialize)VideoPlayer).BeginInit();
            SuspendLayout();
            // 
            // VideoPlayer
            // 
            VideoPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VideoPlayer.Enabled = true;
            VideoPlayer.Location = new Point(0, 0);
            VideoPlayer.Name = "VideoPlayer";
            VideoPlayer.OcxState = (AxHost.State)resources.GetObject("VideoPlayer.OcxState");
            VideoPlayer.Size = new Size(934, 505);
            VideoPlayer.TabIndex = 1;
            VideoPlayer.PlayStateChange += VideoPlayer_PlayStateChange;
            // 
            // PlayList
            // 
            PlayList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PlayList.BackColor = SystemColors.InfoText;
            PlayList.BorderStyle = BorderStyle.None;
            PlayList.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            PlayList.ForeColor = SystemColors.HighlightText;
            PlayList.FormattingEnabled = true;
            PlayList.ItemHeight = 25;
            PlayList.Location = new Point(952, 1);
            PlayList.Name = "PlayList";
            PlayList.Size = new Size(506, 500);
            PlayList.TabIndex = 2;
            PlayList.SelectedIndexChanged += PlayList_SelectedIndexChanged;
            // 
            // fileName
            // 
            fileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fileName.AutoSize = true;
            fileName.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            fileName.Location = new Point(12, 566);
            fileName.Name = "fileName";
            fileName.Size = new Size(144, 28);
            fileName.TabIndex = 3;
            fileName.Text = "等待開啟檔案";
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDuration.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblDuration.Location = new Point(220, 519);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(714, 28);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "詳細資訊";
            lblDuration.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // chooseFolder
            // 
            chooseFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chooseFolder.FlatStyle = FlatStyle.System;
            chooseFolder.Location = new Point(952, 507);
            chooseFolder.Name = "chooseFolder";
            chooseFolder.Size = new Size(506, 55);
            chooseFolder.TabIndex = 5;
            chooseFolder.Text = "選擇資料夾 (&O)";
            chooseFolder.UseVisualStyleBackColor = true;
            chooseFolder.Click += chooseFolder_Click;
            // 
            // pause
            // 
            pause.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pause.FlatStyle = FlatStyle.System;
            pause.Location = new Point(12, 525);
            pause.Name = "pause";
            pause.Size = new Size(31, 34);
            pause.TabIndex = 7;
            pause.Text = "⏸️";
            pause.UseVisualStyleBackColor = true;
            pause.Click += pause_Click;
            // 
            // stop
            // 
            stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            stop.Enabled = false;
            stop.FlatStyle = FlatStyle.System;
            stop.Location = new Point(49, 525);
            stop.Name = "stop";
            stop.Size = new Size(31, 34);
            stop.TabIndex = 8;
            stop.Text = "⏹️";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // fullscreen
            // 
            fullscreen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fullscreen.FlatStyle = FlatStyle.System;
            fullscreen.Location = new Point(86, 525);
            fullscreen.Name = "fullscreen";
            fullscreen.Size = new Size(128, 34);
            fullscreen.TabIndex = 9;
            fullscreen.Text = "↗️ 全螢幕(&F)";
            fullscreen.UseVisualStyleBackColor = true;
            fullscreen.Click += fullscreen_Click;
            // 
            // exit_fullscreen
            // 
            exit_fullscreen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exit_fullscreen.FlatAppearance.BorderSize = 0;
            exit_fullscreen.FlatStyle = FlatStyle.Flat;
            exit_fullscreen.Location = new Point(-1, 568);
            exit_fullscreen.Name = "exit_fullscreen";
            exit_fullscreen.Size = new Size(1474, 35);
            exit_fullscreen.TabIndex = 10;
            exit_fullscreen.Text = "↙️ 離開全螢幕 (&F)";
            exit_fullscreen.UseVisualStyleBackColor = true;
            exit_fullscreen.Visible = false;
            exit_fullscreen.Click += exit_fullscreen_Click;
            // 
            // ellipseContorl2
            // 
            ellipseContorl2.CornerRadius = 25;
            ellipseContorl2.TargetControl = PlayList;
            // 
            // ellipseContorl1
            // 
            ellipseContorl1.CornerRadius = 25;
            ellipseContorl1.TargetControl = VideoPlayer;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 603);
            Controls.Add(exit_fullscreen);
            Controls.Add(VideoPlayer);
            Controls.Add(fullscreen);
            Controls.Add(stop);
            Controls.Add(pause);
            Controls.Add(chooseFolder);
            Controls.Add(lblDuration);
            Controls.Add(fileName);
            Controls.Add(PlayList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form14";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "媒體播放器";
            FormClosing += Form14_FormClosing;
            ((System.ComponentModel.ISupportInitialize)VideoPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private ListBox PlayList;
        private Label fileName;
        private Label lblDuration;
        private System.Windows.Forms.Timer timer1;
        private Button chooseFolder;
        private Button pause;
        private Button stop;
        private Button fullscreen;
        private Button exit_fullscreen;
        private Custom_class.EllipseContorl ellipseContorl2;
        private Custom_class.EllipseContorl ellipseContorl1;
    }
}