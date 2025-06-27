namespace All_tools_Form_Apps
{
    partial class Error_shower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_shower));
            error_icon = new PictureBox();
            title = new Label();
            exit_os = new Button();
            buttons_info = new Label();
            go_front = new Button();
            more_info = new Button();
            texts = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)error_icon).BeginInit();
            SuspendLayout();
            // 
            // error_icon
            // 
            error_icon.Image = (Image)resources.GetObject("error_icon.Image");
            error_icon.Location = new Point(12, 12);
            error_icon.Name = "error_icon";
            error_icon.Size = new Size(151, 154);
            error_icon.SizeMode = PictureBoxSizeMode.Zoom;
            error_icon.TabIndex = 0;
            error_icon.TabStop = false;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            title.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(169, 12);
            title.Name = "title";
            title.Size = new Size(619, 53);
            title.TabIndex = 2;
            title.Text = "標題";
            // 
            // exit_os
            // 
            exit_os.Anchor = AnchorStyles.Bottom;
            exit_os.FlatStyle = FlatStyle.System;
            exit_os.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exit_os.Location = new Point(666, 351);
            exit_os.Name = "exit_os";
            exit_os.Size = new Size(122, 50);
            exit_os.TabIndex = 3;
            exit_os.Text = "中止 (&I)";
            exit_os.UseVisualStyleBackColor = true;
            exit_os.Click += exit_os_Click;
            // 
            // buttons_info
            // 
            buttons_info.Anchor = AnchorStyles.Bottom;
            buttons_info.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttons_info.Location = new Point(12, 267);
            buttons_info.Name = "buttons_info";
            buttons_info.Size = new Size(776, 81);
            buttons_info.TabIndex = 4;
            buttons_info.Text = "按下 [中止] 按鈕將會立即中止此程式，所有未儲存的變更將會遺失!\r\n按下 [繼續] 按鈕，程式將會嘗試略過導致發生錯誤的動作，\r\n按下 [詳細資訊] 按鈕，即可顯示詳細的錯誤資訊，以便排查錯誤。";
            // 
            // go_front
            // 
            go_front.Anchor = AnchorStyles.Bottom;
            go_front.FlatStyle = FlatStyle.System;
            go_front.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            go_front.Location = new Point(538, 351);
            go_front.Name = "go_front";
            go_front.Size = new Size(122, 50);
            go_front.TabIndex = 0;
            go_front.Text = "繼續 (&C)";
            go_front.UseVisualStyleBackColor = true;
            go_front.Click += go_front_Click;
            // 
            // more_info
            // 
            more_info.Anchor = AnchorStyles.Bottom;
            more_info.FlatStyle = FlatStyle.System;
            more_info.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            more_info.Location = new Point(12, 351);
            more_info.Name = "more_info";
            more_info.Size = new Size(164, 50);
            more_info.TabIndex = 6;
            more_info.Text = "詳細資料 (&D)";
            more_info.UseVisualStyleBackColor = true;
            more_info.Click += more_info_Click;
            // 
            // texts
            // 
            texts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            texts.BackColor = SystemColors.Control;
            texts.BorderStyle = BorderStyle.None;
            texts.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            texts.Location = new Point(179, 68);
            texts.Name = "texts";
            texts.ReadOnly = true;
            texts.Size = new Size(609, 196);
            texts.TabIndex = 7;
            texts.Text = "錯誤內容...";
            // 
            // Error_shower
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(texts);
            Controls.Add(more_info);
            Controls.Add(go_front);
            Controls.Add(buttons_info);
            Controls.Add(exit_os);
            Controls.Add(title);
            Controls.Add(error_icon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Error_shower";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "應用程式於未知的地方發生錯誤!";
            Load += Error_shower_Load;
            ((System.ComponentModel.ISupportInitialize)error_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox error_icon;
        private Label title;
        private Button exit_os;
        private Label buttons_info;
        private Button go_front;
        private Button more_info;
        private RichTextBox texts;
    }
}