namespace All_tools_Form_Apps.MessageBoxs
{
    partial class Notepad_messagebox1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad_messagebox1));
            Cancle = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Cancle
            // 
            Cancle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Cancle.DialogResult = DialogResult.Cancel;
            Cancle.Enabled = false;
            Cancle.FlatStyle = FlatStyle.System;
            Cancle.Location = new Point(266, 143);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(112, 34);
            Cancle.TabIndex = 0;
            Cancle.Text = "取消";
            Cancle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(153, 34);
            label1.Name = "label1";
            label1.Size = new Size(175, 60);
            label1.TabIndex = 1;
            label1.Text = "正在儲存檔案...\r\n請稍後...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.downloads;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Notepad_messagebox1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 189);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Cancle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Notepad_messagebox1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "存檔中...";
            FormClosing += Notepad_messagebox1_FormClosing;
            Load += Notepad_messagebox1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancle;
        private Label label1;
        private PictureBox pictureBox1;
    }
}