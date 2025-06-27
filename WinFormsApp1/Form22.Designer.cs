namespace Tomato_clock
{
    partial class Form22
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            start = new Button();
            mins = new NumericUpDown();
            foucsing = new Panel();
            text_timer = new Label();
            stop = new Button();
            tip1 = new Label();
            tip2 = new Label();
            rest_mins = new NumericUpDown();
            tip3 = new Label();
            tip4 = new Label();
            label1 = new Label();
            label2 = new Label();
            repeats = new NumericUpDown();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            show = new ToolStripMenuItem();
            force_exit = new ToolStripMenuItem();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)mins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rest_mins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repeats).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // start
            // 
            start.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            start.FlatStyle = FlatStyle.System;
            start.Font = new Font("Noto Sans TC", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            start.Location = new Point(12, 687);
            start.Name = "start";
            start.Size = new Size(930, 61);
            start.TabIndex = 0;
            start.Text = "↑ 種植番茄 ↑";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // mins
            // 
            mins.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mins.Font = new Font("Noto Sans TC", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            mins.Location = new Point(127, 637);
            mins.Name = "mins";
            mins.Size = new Size(748, 48);
            mins.TabIndex = 1;
            mins.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // foucsing
            // 
            foucsing.Location = new Point(12, 62);
            foucsing.Name = "foucsing";
            foucsing.Size = new Size(350, 460);
            foucsing.TabIndex = 2;
            // 
            // text_timer
            // 
            text_timer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text_timer.Font = new Font("Noto Sans TC", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            text_timer.Location = new Point(368, 62);
            text_timer.Name = "text_timer";
            text_timer.Size = new Size(574, 460);
            text_timer.TabIndex = 3;
            text_timer.Text = "◀ 開始種植你的番茄";
            text_timer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stop
            // 
            stop.Enabled = false;
            stop.FlatStyle = FlatStyle.System;
            stop.Font = new Font("Noto Sans TC", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            stop.Location = new Point(12, 12);
            stop.Name = "stop";
            stop.Size = new Size(135, 44);
            stop.TabIndex = 4;
            stop.Text = "× 停止";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // tip1
            // 
            tip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tip1.AutoSize = true;
            tip1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tip1.Location = new Point(881, 647);
            tip1.Name = "tip1";
            tip1.Size = new Size(61, 30);
            tip1.TabIndex = 5;
            tip1.Text = "分鐘";
            // 
            // tip2
            // 
            tip2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tip2.AutoSize = true;
            tip2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tip2.Location = new Point(881, 593);
            tip2.Name = "tip2";
            tip2.Size = new Size(61, 30);
            tip2.TabIndex = 7;
            tip2.Text = "分鐘";
            // 
            // rest_mins
            // 
            rest_mins.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rest_mins.Font = new Font("Noto Sans TC", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rest_mins.Location = new Point(127, 583);
            rest_mins.Name = "rest_mins";
            rest_mins.Size = new Size(748, 48);
            rest_mins.TabIndex = 6;
            rest_mins.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tip3
            // 
            tip3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tip3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tip3.Location = new Point(12, 593);
            tip3.Name = "tip3";
            tip3.Size = new Size(109, 30);
            tip3.TabIndex = 8;
            tip3.Text = "休息長度";
            tip3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tip4
            // 
            tip4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tip4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tip4.Location = new Point(12, 647);
            tip4.Name = "tip4";
            tip4.Size = new Size(109, 30);
            tip4.TabIndex = 9;
            tip4.Text = "專注長度";
            tip4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 539);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 12;
            label1.Text = "重複次數";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(905, 539);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 11;
            label2.Text = "次";
            // 
            // repeats
            // 
            repeats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            repeats.Font = new Font("Noto Sans TC", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            repeats.Location = new Point(127, 529);
            repeats.Name = "repeats";
            repeats.Size = new Size(772, 48);
            repeats.TabIndex = 10;
            repeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "番茄鐘";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { show, force_exit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 64);
            // 
            // show
            // 
            show.Name = "show";
            show.Size = new Size(144, 30);
            show.Text = "顯示 (&S)";
            show.Click += show_Click;
            // 
            // force_exit
            // 
            force_exit.Name = "force_exit";
            force_exit.Size = new Size(144, 30);
            force_exit.Text = "結束 (&X)";
            force_exit.Click += force_exit_Click;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.FlatStyle = FlatStyle.System;
            exit.Location = new Point(860, 12);
            exit.Name = "exit";
            exit.Size = new Size(82, 44);
            exit.TabIndex = 14;
            exit.Text = "⛔ 結束";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form22
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 760);
            Controls.Add(exit);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(repeats);
            Controls.Add(tip4);
            Controls.Add(tip3);
            Controls.Add(tip2);
            Controls.Add(rest_mins);
            Controls.Add(tip1);
            Controls.Add(stop);
            Controls.Add(text_timer);
            Controls.Add(foucsing);
            Controls.Add(mins);
            Controls.Add(start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(976, 612);
            Name = "Form22";
            Text = "番茄鐘";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)mins).EndInit();
            ((System.ComponentModel.ISupportInitialize)rest_mins).EndInit();
            ((System.ComponentModel.ISupportInitialize)repeats).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private NumericUpDown mins;
        private Panel foucsing;
        private Label text_timer;
        private Button stop;
        private Label tip1;
        private Label tip2;
        private NumericUpDown rest_mins;
        private Label tip3;
        private Label tip4;
        private Label label1;
        private Label label2;
        private NumericUpDown repeats;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem show;
        private ToolStripMenuItem force_exit;
        private Button exit;
    }
}
