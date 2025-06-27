namespace All_tools_Form_Apps.External_res
{
    partial class download_choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(download_choose));
            path = new TextBox();
            choose_path = new Button();
            auto_unzip = new CheckBox();
            auto_run = new CheckBox();
            auto_runplace = new CheckBox();
            start = new Button();
            cancel = new Button();
            filename = new TextBox();
            SuspendLayout();
            // 
            // path
            // 
            path.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            path.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            path.Location = new Point(12, 11);
            path.Name = "path";
            path.PlaceholderText = "下載目的地";
            path.Size = new Size(678, 38);
            path.TabIndex = 0;
            path.Text = "C:\\GeometricgamesApps\\downloads";
            // 
            // choose_path
            // 
            choose_path.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            choose_path.FlatStyle = FlatStyle.System;
            choose_path.Location = new Point(696, 12);
            choose_path.Name = "choose_path";
            choose_path.Size = new Size(86, 38);
            choose_path.TabIndex = 1;
            choose_path.Text = "選擇";
            choose_path.UseVisualStyleBackColor = true;
            choose_path.Click += choose_path_Click;
            // 
            // auto_unzip
            // 
            auto_unzip.AutoSize = true;
            auto_unzip.Checked = true;
            auto_unzip.CheckState = CheckState.Checked;
            auto_unzip.FlatStyle = FlatStyle.System;
            auto_unzip.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            auto_unzip.Location = new Point(12, 99);
            auto_unzip.Name = "auto_unzip";
            auto_unzip.Size = new Size(171, 35);
            auto_unzip.TabIndex = 2;
            auto_unzip.Text = "自動解壓縮";
            auto_unzip.UseVisualStyleBackColor = true;
            auto_unzip.CheckedChanged += auto_unzip_CheckedChanged;
            // 
            // auto_run
            // 
            auto_run.AutoSize = true;
            auto_run.Checked = true;
            auto_run.CheckState = CheckState.Checked;
            auto_run.FlatStyle = FlatStyle.System;
            auto_run.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            auto_run.Location = new Point(12, 140);
            auto_run.Name = "auto_run";
            auto_run.Size = new Size(171, 35);
            auto_run.TabIndex = 3;
            auto_run.Text = "完成後開啟";
            auto_run.UseVisualStyleBackColor = true;
            // 
            // auto_runplace
            // 
            auto_runplace.AutoSize = true;
            auto_runplace.FlatStyle = FlatStyle.System;
            auto_runplace.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            auto_runplace.Location = new Point(12, 181);
            auto_runplace.Name = "auto_runplace";
            auto_runplace.Size = new Size(267, 35);
            auto_runplace.TabIndex = 4;
            auto_runplace.Text = "完成後顯示檔案位置";
            auto_runplace.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            start.FlatStyle = FlatStyle.System;
            start.Location = new Point(634, 175);
            start.Name = "start";
            start.Size = new Size(148, 51);
            start.TabIndex = 5;
            start.Text = "開始下載 (&S)";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // cancel
            // 
            cancel.FlatStyle = FlatStyle.System;
            cancel.Location = new Point(480, 175);
            cancel.Name = "cancel";
            cancel.Size = new Size(148, 51);
            cancel.TabIndex = 6;
            cancel.Text = "取消 (&C)";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // filename
            // 
            filename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filename.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            filename.Location = new Point(12, 55);
            filename.Name = "filename";
            filename.PlaceholderText = "資料夾名稱";
            filename.Size = new Size(770, 38);
            filename.TabIndex = 7;
            filename.Text = "default";
            // 
            // download_choose
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 238);
            Controls.Add(filename);
            Controls.Add(cancel);
            Controls.Add(start);
            Controls.Add(auto_runplace);
            Controls.Add(auto_run);
            Controls.Add(auto_unzip);
            Controls.Add(choose_path);
            Controls.Add(path);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "download_choose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "選擇下載地點";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox path;
        private Button choose_path;
        private CheckBox auto_unzip;
        private CheckBox auto_run;
        private CheckBox auto_runplace;
        private Button start;
        private Button cancel;
        private TextBox filename;
    }
}