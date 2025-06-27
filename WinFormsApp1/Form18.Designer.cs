namespace All_tools_Form_Apps
{
    partial class Form18
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
            download_folder = new TextBox();
            choose_folder = new Button();
            link = new TextBox();
            download = new Button();
            SuspendLayout();
            // 
            // download_folder
            // 
            download_folder.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            download_folder.Location = new Point(12, 61);
            download_folder.Name = "download_folder";
            download_folder.PlaceholderText = "下載至...";
            download_folder.Size = new Size(677, 43);
            download_folder.TabIndex = 0;
            // 
            // choose_folder
            // 
            choose_folder.FlatStyle = FlatStyle.System;
            choose_folder.Location = new Point(695, 61);
            choose_folder.Name = "choose_folder";
            choose_folder.Size = new Size(93, 43);
            choose_folder.TabIndex = 1;
            choose_folder.Text = "選擇...";
            choose_folder.UseVisualStyleBackColor = true;
            choose_folder.Click += choose_folder_Click;
            // 
            // link
            // 
            link.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            link.Location = new Point(12, 12);
            link.Name = "link";
            link.PlaceholderText = "請輸入網址(例如https://example.com/test.txt)";
            link.Size = new Size(776, 43);
            link.TabIndex = 2;
            // 
            // download
            // 
            download.FlatStyle = FlatStyle.System;
            download.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            download.Location = new Point(12, 110);
            download.Name = "download";
            download.Size = new Size(776, 81);
            download.TabIndex = 3;
            download.Text = "下載";
            download.UseVisualStyleBackColor = true;
            download.Click += download_Click;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(download);
            Controls.Add(link);
            Controls.Add(choose_folder);
            Controls.Add(download_folder);
            Name = "Form18";
            Text = "檔案下載器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox download_folder;
        private Button choose_folder;
        private TextBox link;
        private Button download;
    }
}