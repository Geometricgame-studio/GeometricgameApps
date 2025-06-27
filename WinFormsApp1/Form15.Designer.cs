namespace All_tools_Form_Apps
{
    partial class Form15
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
            btnDownload = new Button();
            txturl = new TextBox();
            txtdownloadplace = new TextBox();
            browsefile = new Button();
            txtdownloadname = new TextBox();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.FlatStyle = FlatStyle.System;
            btnDownload.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnDownload.Location = new Point(13, 160);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(799, 51);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "下載影片";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // txturl
            // 
            txturl.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txturl.Location = new Point(13, 11);
            txturl.Name = "txturl";
            txturl.PlaceholderText = "輸入影片連結";
            txturl.Size = new Size(799, 48);
            txturl.TabIndex = 1;
            // 
            // txtdownloadplace
            // 
            txtdownloadplace.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtdownloadplace.Location = new Point(13, 61);
            txtdownloadplace.Name = "txtdownloadplace";
            txtdownloadplace.PlaceholderText = "下載位置";
            txtdownloadplace.Size = new Size(709, 48);
            txtdownloadplace.TabIndex = 2;
            // 
            // browsefile
            // 
            browsefile.FlatStyle = FlatStyle.System;
            browsefile.Location = new Point(729, 61);
            browsefile.Name = "browsefile";
            browsefile.Size = new Size(84, 44);
            browsefile.TabIndex = 3;
            browsefile.Text = "選擇";
            browsefile.UseVisualStyleBackColor = true;
            browsefile.Click += browsefile_Click;
            // 
            // txtdownloadname
            // 
            txtdownloadname.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtdownloadname.Location = new Point(13, 110);
            txtdownloadname.Name = "txtdownloadname";
            txtdownloadname.PlaceholderText = "下載檔案名稱 (選填)";
            txtdownloadname.Size = new Size(799, 48);
            txtdownloadname.TabIndex = 4;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 223);
            Controls.Add(txtdownloadname);
            Controls.Add(browsefile);
            Controls.Add(txtdownloadplace);
            Controls.Add(txturl);
            Controls.Add(btnDownload);
            MaximizeBox = false;
            Name = "Form15";
            Text = "Youtube影片下載器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private TextBox txturl;
        private TextBox txtdownloadplace;
        private Button browsefile;
        private TextBox txtdownloadname;
    }
}