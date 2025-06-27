namespace All_tools_Form_Apps
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Start = new Button();
            Play = new Button();
            Reset = new Button();
            Timer = new Label();
            nowthing = new Label();
            text1 = new Label();
            Auto_replay = new CheckBox();
            Auto_replay_sec = new NumericUpDown();
            text2 = new Label();
            start_show_taskbar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Auto_replay_sec).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.FlatStyle = FlatStyle.System;
            Start.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Start.Location = new Point(12, 136);
            Start.Name = "Start";
            Start.Size = new Size(196, 45);
            Start.TabIndex = 0;
            Start.Text = "開始錄製(&S)";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Play
            // 
            Play.FlatStyle = FlatStyle.System;
            Play.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Play.Location = new Point(214, 136);
            Play.Name = "Play";
            Play.Size = new Size(196, 45);
            Play.TabIndex = 1;
            Play.Text = "播放(&P)";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Reset
            // 
            Reset.FlatStyle = FlatStyle.System;
            Reset.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Reset.Location = new Point(416, 136);
            Reset.Name = "Reset";
            Reset.Size = new Size(196, 45);
            Reset.TabIndex = 2;
            Reset.Text = "重新錄製(&R)";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Font = new Font("Poppins", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Timer.Location = new Point(12, 9);
            Timer.Name = "Timer";
            Timer.Size = new Size(353, 78);
            Timer.TabIndex = 3;
            Timer.Text = "Ready to Start";
            // 
            // nowthing
            // 
            nowthing.AutoSize = true;
            nowthing.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            nowthing.Location = new Point(12, 87);
            nowthing.Name = "nowthing";
            nowthing.Size = new Size(71, 36);
            nowthing.TabIndex = 4;
            nowthing.Text = "就緒";
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            text1.Location = new Point(12, 195);
            text1.Name = "text1";
            text1.Size = new Size(127, 36);
            text1.TabIndex = 5;
            text1.Text = "進階選項";
            // 
            // Auto_replay
            // 
            Auto_replay.AutoSize = true;
            Auto_replay.Enabled = false;
            Auto_replay.FlatStyle = FlatStyle.System;
            Auto_replay.Location = new Point(12, 234);
            Auto_replay.Name = "Auto_replay";
            Auto_replay.Size = new Size(120, 28);
            Auto_replay.TabIndex = 6;
            Auto_replay.Text = "重複播放";
            Auto_replay.UseVisualStyleBackColor = true;
            Auto_replay.CheckedChanged += Auto_replay_CheckedChanged;
            // 
            // Auto_replay_sec
            // 
            Auto_replay_sec.Enabled = false;
            Auto_replay_sec.Location = new Point(135, 268);
            Auto_replay_sec.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            Auto_replay_sec.Name = "Auto_replay_sec";
            Auto_replay_sec.Size = new Size(180, 30);
            Auto_replay_sec.TabIndex = 7;
            Auto_replay_sec.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new Point(12, 270);
            text2.Name = "text2";
            text2.Size = new Size(117, 23);
            text2.TabIndex = 8;
            text2.Text = "重複間隔 (秒)";
            // 
            // start_show_taskbar
            // 
            start_show_taskbar.AutoSize = true;
            start_show_taskbar.Location = new Point(12, 312);
            start_show_taskbar.Name = "start_show_taskbar";
            start_show_taskbar.Size = new Size(216, 27);
            start_show_taskbar.TabIndex = 9;
            start_show_taskbar.Text = "播放開始時顯示工作列";
            start_show_taskbar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 351);
            Controls.Add(start_show_taskbar);
            Controls.Add(text2);
            Controls.Add(Auto_replay_sec);
            Controls.Add(Auto_replay);
            Controls.Add(text1);
            Controls.Add(nowthing);
            Controls.Add(Timer);
            Controls.Add(Reset);
            Controls.Add(Play);
            Controls.Add(Start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form4";
            Text = "游標錄製器";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            MouseClick += Form4_MouseClick;
            ((System.ComponentModel.ISupportInitialize)Auto_replay_sec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Play;
        private Button Reset;
        private Label Timer;
        private Label nowthing;
        private Label text1;
        private CheckBox Auto_replay;
        private NumericUpDown Auto_replay_sec;
        private Label text2;
        private CheckBox start_show_taskbar;
    }
}