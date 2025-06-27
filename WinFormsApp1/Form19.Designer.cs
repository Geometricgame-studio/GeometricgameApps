namespace All_tools_Form_Apps
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            choose_file = new Button();
            infoText = new RichTextBox();
            SuspendLayout();
            // 
            // choose_file
            // 
            choose_file.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            choose_file.FlatStyle = FlatStyle.System;
            choose_file.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            choose_file.Location = new Point(12, 12);
            choose_file.Name = "choose_file";
            choose_file.Size = new Size(1132, 82);
            choose_file.TabIndex = 0;
            choose_file.Text = "選擇要讀取的檔案 (&C)";
            choose_file.UseVisualStyleBackColor = true;
            choose_file.Click += choose_file_Click;
            // 
            // infoText
            // 
            infoText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoText.BackColor = SystemColors.ControlLightLight;
            infoText.BorderStyle = BorderStyle.None;
            infoText.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            infoText.Location = new Point(12, 97);
            infoText.Name = "infoText";
            infoText.ReadOnly = true;
            infoText.Size = new Size(1132, 478);
            infoText.TabIndex = 2;
            infoText.Text = "";
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 587);
            Controls.Add(infoText);
            Controls.Add(choose_file);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(674, 261);
            Name = "Form19";
            Text = "查看檔案資訊";
            ResumeLayout(false);
        }

        #endregion

        private Button choose_file;
        private RichTextBox infoText;
    }
}