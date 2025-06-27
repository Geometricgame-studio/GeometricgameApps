namespace All_tools_Form_Apps.Setting
{
    partial class personal_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personal_settings));
            confirm = new Button();
            cancel = new Button();
            d1_change_fonts = new Button();
            title = new Label();
            title_png = new PictureBox();
            startup_action = new Custom_class.ToggleButton();
            setting_1text = new Label();
            info_bar = new Label();
            close_info_bar = new Button();
            ((System.ComponentModel.ISupportInitialize)title_png).BeginInit();
            SuspendLayout();
            // 
            // confirm
            // 
            confirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            confirm.FlatStyle = FlatStyle.System;
            confirm.Location = new Point(793, 334);
            confirm.Margin = new Padding(4);
            confirm.Name = "confirm";
            confirm.Size = new Size(137, 44);
            confirm.TabIndex = 2;
            confirm.Text = "確定 (&O)";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel.FlatStyle = FlatStyle.System;
            cancel.Location = new Point(651, 334);
            cancel.Margin = new Padding(4);
            cancel.Name = "cancel";
            cancel.Size = new Size(134, 44);
            cancel.TabIndex = 3;
            cancel.Text = "取消 (&C)";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // d1_change_fonts
            // 
            d1_change_fonts.FlatStyle = FlatStyle.Flat;
            d1_change_fonts.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            d1_change_fonts.Location = new Point(13, 72);
            d1_change_fonts.Margin = new Padding(4);
            d1_change_fonts.Name = "d1_change_fonts";
            d1_change_fonts.Size = new Size(276, 59);
            d1_change_fonts.TabIndex = 4;
            d1_change_fonts.Text = "更改預設字體";
            d1_change_fonts.UseVisualStyleBackColor = true;
            d1_change_fonts.Click += d1_change_fonts_Click;
            // 
            // title
            // 
            title.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(75, 12);
            title.Name = "title";
            title.Size = new Size(337, 53);
            title.TabIndex = 5;
            title.Text = "個人化設定";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // title_png
            // 
            title_png.Image = (Image)resources.GetObject("title_png.Image");
            title_png.InitialImage = (Image)resources.GetObject("title_png.InitialImage");
            title_png.Location = new Point(12, 12);
            title_png.Name = "title_png";
            title_png.Size = new Size(57, 53);
            title_png.SizeMode = PictureBoxSizeMode.Zoom;
            title_png.TabIndex = 6;
            title_png.TabStop = false;
            // 
            // startup_action
            // 
            startup_action.Location = new Point(13, 138);
            startup_action.MinimumSize = new Size(45, 22);
            startup_action.Name = "startup_action";
            startup_action.OffBackColor = Color.Gray;
            startup_action.OffToggleColor = Color.Gainsboro;
            startup_action.OnBackColor = Color.MediumSlateBlue;
            startup_action.OnToggleColor = Color.WhiteSmoke;
            startup_action.Size = new Size(65, 35);
            startup_action.TabIndex = 7;
            startup_action.UseVisualStyleBackColor = true;
            startup_action.CheckedChanged += startup_action_CheckedChanged;
            // 
            // setting_1text
            // 
            setting_1text.Location = new Point(93, 138);
            setting_1text.Name = "setting_1text";
            setting_1text.Size = new Size(187, 35);
            setting_1text.TabIndex = 8;
            setting_1text.Text = "系統啟動動畫";
            setting_1text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // info_bar
            // 
            info_bar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            info_bar.BackColor = SystemColors.Info;
            info_bar.Location = new Point(1, 0);
            info_bar.Name = "info_bar";
            info_bar.Size = new Size(941, 30);
            info_bar.TabIndex = 9;
            info_bar.Text = "通知訊息\r\n";
            info_bar.TextAlign = ContentAlignment.MiddleCenter;
            info_bar.Visible = false;
            info_bar.VisibleChanged += info_bar_VisibleChanged;
            // 
            // close_info_bar
            // 
            close_info_bar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_info_bar.BackColor = SystemColors.Info;
            close_info_bar.FlatAppearance.BorderSize = 0;
            close_info_bar.FlatStyle = FlatStyle.Flat;
            close_info_bar.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            close_info_bar.Location = new Point(909, -7);
            close_info_bar.Name = "close_info_bar";
            close_info_bar.Size = new Size(33, 37);
            close_info_bar.TabIndex = 10;
            close_info_bar.Text = "×";
            close_info_bar.TextAlign = ContentAlignment.TopCenter;
            close_info_bar.UseVisualStyleBackColor = false;
            close_info_bar.Visible = false;
            close_info_bar.Click += close_info_bar_Click;
            // 
            // personal_settings
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 391);
            Controls.Add(close_info_bar);
            Controls.Add(info_bar);
            Controls.Add(setting_1text);
            Controls.Add(startup_action);
            Controls.Add(title_png);
            Controls.Add(title);
            Controls.Add(d1_change_fonts);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "personal_settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "個人化設定";
            Load += personal_settings_Load;
            ((System.ComponentModel.ISupportInitialize)title_png).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button confirm;
        private Button cancel;
        private Button d1_change_fonts;
        private Label title;
        private PictureBox title_png;
        private Custom_class.ToggleButton startup_action;
        private Label setting_1text;
        private Label info_bar;
        private Button close_info_bar;
    }
}