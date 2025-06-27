namespace All_tools_Form_Apps
{
    partial class Form12
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
            goto_url = new Button();
            richTextBox1 = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            URLs = new TextBox();
            SuspendLayout();
            // 
            // goto_url
            // 
            goto_url.Location = new Point(1337, 12);
            goto_url.Name = "goto_url";
            goto_url.Size = new Size(104, 34);
            goto_url.TabIndex = 1;
            goto_url.Text = "GO!";
            goto_url.UseVisualStyleBackColor = true;
            goto_url.Click += goto_url_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1429, 563);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // URLs
            // 
            URLs.Location = new Point(12, 12);
            URLs.Name = "URLs";
            URLs.PlaceholderText = "請輸入連結或網址!";
            URLs.Size = new Size(1319, 30);
            URLs.TabIndex = 0;
            URLs.KeyDown += URLs_KeyDown;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 714);
            Controls.Add(richTextBox1);
            Controls.Add(goto_url);
            Controls.Add(URLs);
            MaximizeBox = false;
            Name = "Form12";
            Text = "瀏覽器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button goto_url;
        private RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox URLs;
    }
}