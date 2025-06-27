using All_tools_Form_Apps.Properties;
using System.Resources;

namespace All_tools_Form_Apps.MessageBoxs
{
    partial class single_download
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
            tool_name = new Label();
            download = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // tool_name
            // 
            tool_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tool_name.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tool_name.Location = new Point(12, 9);
            tool_name.Name = "tool_name";
            tool_name.Size = new Size(552, 45);
            tool_name.TabIndex = 0;
            tool_name.Text = "可以下載獨立化的工具";
            tool_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // download
            // 
            download.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            download.FlatStyle = FlatStyle.System;
            download.Location = new Point(452, 78);
            download.Name = "download";
            download.Size = new Size(112, 46);
            download.TabIndex = 1;
            download.Text = "下載 (&D)";
            download.UseVisualStyleBackColor = true;
            download.Click += download_Click;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancel.FlatStyle = FlatStyle.System;
            cancel.Location = new Point(12, 78);
            cancel.Name = "cancel";
            cancel.Size = new Size(112, 46);
            cancel.TabIndex = 2;
            cancel.Text = "取消 (&C)";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // single_download
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 136);
            Controls.Add(cancel);
            Controls.Add(download);
            Controls.Add(tool_name);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "single_download";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "下載獨立的工具";
            ResumeLayout(false);
        }

        #endregion

        private Label tool_name;
        private Button download;
        private Button cancel;
    }
}