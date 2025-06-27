namespace All_tools_Form_Apps
{
    partial class Form20
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
            timer = new Button();
            nothing = new Button();
            showtext = new Button();
            countdown = new Button();
            showpictrue = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer
            // 
            timer.FlatStyle = FlatStyle.System;
            timer.Location = new Point(12, 174);
            timer.Name = "timer";
            timer.Size = new Size(124, 53);
            timer.TabIndex = 0;
            timer.Text = "顯示時間";
            timer.UseVisualStyleBackColor = true;
            timer.Click += timer_Click;
            // 
            // nothing
            // 
            nothing.FlatStyle = FlatStyle.System;
            nothing.Location = new Point(14, 12);
            nothing.Name = "nothing";
            nothing.Size = new Size(526, 53);
            nothing.TabIndex = 1;
            nothing.Text = "不顯示任何物件";
            nothing.UseVisualStyleBackColor = true;
            nothing.Click += nothing_Click;
            // 
            // showtext
            // 
            showtext.FlatStyle = FlatStyle.System;
            showtext.Location = new Point(142, 174);
            showtext.Name = "showtext";
            showtext.Size = new Size(132, 53);
            showtext.TabIndex = 2;
            showtext.Text = "顯示指定文字";
            showtext.UseVisualStyleBackColor = true;
            showtext.Click += showtext_Click;
            // 
            // countdown
            // 
            countdown.Enabled = false;
            countdown.FlatStyle = FlatStyle.System;
            countdown.Location = new Point(280, 174);
            countdown.Name = "countdown";
            countdown.Size = new Size(124, 53);
            countdown.TabIndex = 3;
            countdown.Text = "顯示計時器";
            countdown.UseVisualStyleBackColor = true;
            // 
            // showpictrue
            // 
            showpictrue.FlatStyle = FlatStyle.System;
            showpictrue.Location = new Point(410, 174);
            showpictrue.Name = "showpictrue";
            showpictrue.Size = new Size(128, 53);
            showpictrue.TabIndex = 4;
            showpictrue.Text = "顯示指定圖片";
            showpictrue.UseVisualStyleBackColor = true;
            showpictrue.Click += showpictrue_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(14, 68);
            label1.Name = "label1";
            label1.Size = new Size(524, 103);
            label1.TabIndex = 5;
            label1.Text = "請選擇要以哪種方式控制螢幕。";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(label1);
            Controls.Add(showpictrue);
            Controls.Add(countdown);
            Controls.Add(showtext);
            Controls.Add(nothing);
            Controls.Add(timer);
            Name = "Form20";
            Text = "螢幕控制器";
            ResumeLayout(false);
        }

        #endregion

        private Button timer;
        private Button nothing;
        private Button showtext;
        private Button countdown;
        private Button showpictrue;
        private Label label1;
    }
}