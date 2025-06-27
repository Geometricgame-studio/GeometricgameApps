namespace All_tools_Form_Apps.External_res
{
    partial class downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(downloader));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            title = new Label();
            progressBar1 = new ProgressBar();
            cancel = new Button();
            step = new Label();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(635, 58);
            title.TabIndex = 0;
            title.Text = "正在處理您的下載流程，請稍後...";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 141);
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(517, 34);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            progressBar1.Value = 100;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel.FlatStyle = FlatStyle.System;
            cancel.Location = new Point(535, 141);
            cancel.Name = "cancel";
            cancel.Size = new Size(112, 34);
            cancel.TabIndex = 2;
            cancel.Text = "取消 (&C)";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // step
            // 
            step.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            step.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            step.Location = new Point(12, 67);
            step.Name = "step";
            step.Size = new Size(635, 58);
            step.TabIndex = 3;
            step.Text = "正在準備開始下載...";
            step.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // downloader
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 187);
            ControlBox = false;
            Controls.Add(step);
            Controls.Add(cancel);
            Controls.Add(progressBar1);
            Controls.Add(title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "downloader";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "正在處理下載...";
            FormClosing += downloader_FormClosing;
            Load += downloader_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label title;
        private ProgressBar progressBar1;
        private Button cancel;
        private Label step;
    }
}