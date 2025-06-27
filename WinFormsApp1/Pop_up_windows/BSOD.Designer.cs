namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class BSOD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSOD));
            TITLE = new Label();
            texts = new Label();
            complete = new Label();
            pictureBox1 = new PictureBox();
            little_text = new Label();
            label1 = new Label();
            shutdown = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TITLE
            // 
            TITLE.BackColor = Color.Black;
            TITLE.Cursor = Cursors.WaitCursor;
            TITLE.Font = new Font("Microsoft JhengHei UI", 100F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TITLE.ForeColor = Color.White;
            TITLE.Location = new Point(12, 9);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(1658, 255);
            TITLE.TabIndex = 0;
            TITLE.Text = "._.";
            TITLE.TextAlign = ContentAlignment.TopCenter;
            // 
            // texts
            // 
            texts.BackColor = Color.Black;
            texts.Cursor = Cursors.WaitCursor;
            texts.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            texts.ForeColor = Color.White;
            texts.Location = new Point(12, 339);
            texts.Name = "texts";
            texts.Size = new Size(1658, 169);
            texts.TabIndex = 1;
            texts.Text = "啟動器無法啟動作業系統，如果此情況持續發生請洽專業人員。\r\n正在收集錯誤資訊...\r\n請在啟動器關閉後再試一次!";
            texts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // complete
            // 
            complete.BackColor = Color.Black;
            complete.Cursor = Cursors.WaitCursor;
            complete.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            complete.ForeColor = Color.White;
            complete.Location = new Point(12, 537);
            complete.Name = "complete";
            complete.Size = new Size(1658, 50);
            complete.TabIndex = 2;
            complete.Text = "已完成";
            complete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.WaitCursor;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 792);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1658, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // little_text
            // 
            little_text.BackColor = Color.Black;
            little_text.Cursor = Cursors.WaitCursor;
            little_text.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            little_text.ForeColor = Color.White;
            little_text.Location = new Point(12, 640);
            little_text.Name = "little_text";
            little_text.Size = new Size(1658, 39);
            little_text.TabIndex = 4;
            little_text.Text = "了解更多關於本問題的資訊以及可能的解決辦法請造訪 https/freegeometricgames.com/system_crash\r\n\r\n";
            little_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Cursor = Cursors.WaitCursor;
            label1.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 710);
            label1.Name = "label1";
            label1.Size = new Size(1658, 79);
            label1.TabIndex = 5;
            label1.Text = "如果您通知了支援人員，請告訴他以下資訊:\r\n\r\n停止代碼: STARTUP_FAIL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shutdown
            // 
            shutdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shutdown.BackColor = Color.Black;
            shutdown.Cursor = Cursors.WaitCursor;
            shutdown.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            shutdown.ForeColor = Color.White;
            shutdown.Location = new Point(12, 9);
            shutdown.Name = "shutdown";
            shutdown.Size = new Size(1658, 1091);
            shutdown.TabIndex = 6;
            shutdown.Text = "正在關機...";
            shutdown.TextAlign = ContentAlignment.MiddleCenter;
            shutdown.Visible = false;
            // 
            // BSOD
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1682, 1109);
            ControlBox = false;
            Controls.Add(shutdown);
            Controls.Add(label1);
            Controls.Add(little_text);
            Controls.Add(pictureBox1);
            Controls.Add(complete);
            Controls.Add(texts);
            Controls.Add(TITLE);
            ForeColor = SystemColors.ControlLightLight;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BSOD";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += BSOD_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label TITLE;
        private Label texts;
        private Label complete;
        private PictureBox pictureBox1;
        private Label little_text;
        private Label label1;
        private Label shutdown;
    }
}