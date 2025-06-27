namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class Notepad_About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad_About));
            pictureBox1 = new PictureBox();
            ToolName = new Label();
            text1 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ToolName
            // 
            ToolName.AutoSize = true;
            ToolName.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            ToolName.Location = new Point(158, 67);
            ToolName.Name = "ToolName";
            ToolName.Size = new Size(513, 50);
            ToolName.TabIndex = 1;
            ToolName.Text = "Geometricgame NotePad";
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            text1.Location = new Point(19, 155);
            text1.Name = "text1";
            text1.Size = new Size(394, 330);
            text1.TabIndex = 2;
            text1.Text = "版本: v1.3.0\r\n\r\n版本編號: 0020\r\n\r\n產品適用執行環境: Windows11\r\n\r\n發行時間: 2024/7/11日\r\n\r\n發行者: Geometricgames Studio®️\r\n\r\n產品概述: 文字編輯器";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(159, 16);
            label1.Name = "label1";
            label1.Size = new Size(71, 36);
            label1.TabIndex = 3;
            label1.Text = "關於";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(652, 429);
            button1.Name = "button1";
            button1.Size = new Size(127, 56);
            button1.TabIndex = 4;
            button1.Text = "確定(&O)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Notepad_About
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 501);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(text1);
            Controls.Add(ToolName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Notepad_About";
            Padding = new Padding(16);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "關於NotePad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label ToolName;
        private Label text1;
        private Label label1;
        private Button button1;
    }
}
