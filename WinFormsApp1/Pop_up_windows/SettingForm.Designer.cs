namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class SettingForm
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
            opacity = new ComboBox();
            setting_name1 = new Label();
            title = new Label();
            Apply = new Button();
            Cancle = new Button();
            SuspendLayout();
            // 
            // opacity
            // 
            opacity.Cursor = Cursors.Hand;
            opacity.DropDownStyle = ComboBoxStyle.DropDownList;
            opacity.FlatStyle = FlatStyle.System;
            opacity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            opacity.FormattingEnabled = true;
            opacity.Items.AddRange(new object[] { "0.1", "0.15", "0.2", "0.25", "0.3", "0.35", "0.4", "0.45", "0.5", "0.55", "0.6", "0.65", "0.7", "0.75", "0.8", "0.85", "0.9", "0.95", "1.0" });
            opacity.Location = new Point(164, 91);
            opacity.Name = "opacity";
            opacity.Size = new Size(182, 38);
            opacity.TabIndex = 0;
            // 
            // setting_name1
            // 
            setting_name1.AutoSize = true;
            setting_name1.Font = new Font("Microsoft JhengHei UI", 16F);
            setting_name1.Location = new Point(12, 91);
            setting_name1.Name = "setting_name1";
            setting_name1.Size = new Size(146, 41);
            setting_name1.TabIndex = 1;
            setting_name1.Text = "不透明度";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(112, 56);
            title.TabIndex = 2;
            title.Text = "設定";
            // 
            // Apply
            // 
            Apply.FlatStyle = FlatStyle.System;
            Apply.Location = new Point(316, 404);
            Apply.Name = "Apply";
            Apply.Size = new Size(112, 34);
            Apply.TabIndex = 3;
            Apply.Text = "套用";
            Apply.UseVisualStyleBackColor = true;
            Apply.Click += Apply_Click;
            // 
            // Cancle
            // 
            Cancle.FlatStyle = FlatStyle.System;
            Cancle.Location = new Point(198, 404);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(112, 34);
            Cancle.TabIndex = 4;
            Cancle.Text = "確定";
            Cancle.UseVisualStyleBackColor = true;
            Cancle.Click += Cancle_Click;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(Cancle);
            Controls.Add(Apply);
            Controls.Add(title);
            Controls.Add(setting_name1);
            Controls.Add(opacity);
            Name = "SettingForm";
            Text = "設定";
            FormClosing += settingform_FormClosing;
            Load += SettingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox opacity;
        private Label setting_name1;
        private Label title;
        private Button Apply;
        private Button Cancle;
    }
}