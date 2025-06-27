namespace All_tools_Form_Apps
{
    partial class minecraft_hack
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            start_delay = new NumericUpDown();
            label3 = new Label();
            repeat_click = new RadioButton();
            label2 = new Label();
            start_action = new ComboBox();
            repeat_sec = new NumericUpDown();
            repeat_seconds = new RadioButton();
            repeat_times = new RadioButton();
            repeat_num = new NumericUpDown();
            start = new Button();
            label1 = new Label();
            repeat_ticks = new NumericUpDown();
            tabPage2 = new TabPage();
            label6 = new Label();
            start_key = new ComboBox();
            start_clicking = new Button();
            clickstart_delay = new NumericUpDown();
            label4 = new Label();
            click_repeat_seconds = new NumericUpDown();
            click_repeat_sec = new RadioButton();
            click_repeat_time = new RadioButton();
            click_repeat_times = new NumericUpDown();
            label5 = new Label();
            click_ticks = new NumericUpDown();
            tabPage3 = new TabPage();
            start_walking_delay = new NumericUpDown();
            label7 = new Label();
            running = new CheckBox();
            walking_sec = new NumericUpDown();
            start_walking = new Button();
            tabPage4 = new TabPage();
            start_spamming = new Button();
            label9 = new Label();
            spam_delay = new NumericUpDown();
            label8 = new Label();
            copy_use_text = new TextBox();
            ctrlv_int = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)start_delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repeat_sec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repeat_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repeat_ticks).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clickstart_delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)click_repeat_seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)click_repeat_times).BeginInit();
            ((System.ComponentModel.ISupportInitialize)click_ticks).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)start_walking_delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)walking_sec).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spam_delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctrlv_int).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 452);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(start_delay);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(repeat_click);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(start_action);
            tabPage1.Controls.Add(repeat_sec);
            tabPage1.Controls.Add(repeat_seconds);
            tabPage1.Controls.Add(repeat_times);
            tabPage1.Controls.Add(repeat_num);
            tabPage1.Controls.Add(start);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(repeat_ticks);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "訊息瘋狂發送器";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // start_delay
            // 
            start_delay.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start_delay.Location = new Point(119, 252);
            start_delay.Name = "start_delay";
            start_delay.Size = new Size(669, 43);
            start_delay.TabIndex = 11;
            start_delay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(8, 257);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 10;
            label3.Text = "開始延遲";
            // 
            // repeat_click
            // 
            repeat_click.AutoSize = true;
            repeat_click.Enabled = false;
            repeat_click.FlatStyle = FlatStyle.System;
            repeat_click.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            repeat_click.Location = new Point(8, 153);
            repeat_click.Name = "repeat_click";
            repeat_click.Size = new Size(193, 35);
            repeat_click.TabIndex = 9;
            repeat_click.Text = "重複直到停止";
            repeat_click.UseVisualStyleBackColor = true;
            repeat_click.CheckedChanged += repeat_click_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(6, 211);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 8;
            label2.Text = "當開始時";
            // 
            // start_action
            // 
            start_action.DisplayMember = "3";
            start_action.DropDownStyle = ComboBoxStyle.DropDownList;
            start_action.Enabled = false;
            start_action.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            start_action.FormattingEnabled = true;
            start_action.Items.AddRange(new object[] { "不動作", "最小化視窗直到結束", "隱藏視窗直到結束" });
            start_action.Location = new Point(119, 208);
            start_action.Name = "start_action";
            start_action.RightToLeft = RightToLeft.No;
            start_action.Size = new Size(667, 38);
            start_action.TabIndex = 7;
            // 
            // repeat_sec
            // 
            repeat_sec.Enabled = false;
            repeat_sec.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repeat_sec.Location = new Point(159, 104);
            repeat_sec.Name = "repeat_sec";
            repeat_sec.Size = new Size(629, 43);
            repeat_sec.TabIndex = 6;
            repeat_sec.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // repeat_seconds
            // 
            repeat_seconds.AutoSize = true;
            repeat_seconds.Enabled = false;
            repeat_seconds.FlatStyle = FlatStyle.System;
            repeat_seconds.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            repeat_seconds.Location = new Point(8, 108);
            repeat_seconds.Name = "repeat_seconds";
            repeat_seconds.Size = new Size(145, 35);
            repeat_seconds.TabIndex = 5;
            repeat_seconds.Text = "重複秒數";
            repeat_seconds.UseVisualStyleBackColor = true;
            repeat_seconds.CheckedChanged += repeat_seconds_CheckedChanged;
            // 
            // repeat_times
            // 
            repeat_times.AutoSize = true;
            repeat_times.Checked = true;
            repeat_times.FlatStyle = FlatStyle.System;
            repeat_times.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            repeat_times.Location = new Point(8, 59);
            repeat_times.Name = "repeat_times";
            repeat_times.Size = new Size(145, 35);
            repeat_times.TabIndex = 4;
            repeat_times.TabStop = true;
            repeat_times.Text = "重複次數";
            repeat_times.UseVisualStyleBackColor = true;
            repeat_times.CheckedChanged += repeat_times_CheckedChanged;
            // 
            // repeat_num
            // 
            repeat_num.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repeat_num.Location = new Point(159, 55);
            repeat_num.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            repeat_num.Name = "repeat_num";
            repeat_num.Size = new Size(629, 43);
            repeat_num.TabIndex = 3;
            repeat_num.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // start
            // 
            start.FlatStyle = FlatStyle.System;
            start.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 136);
            start.Location = new Point(6, 325);
            start.Name = "start";
            start.Size = new Size(782, 88);
            start.TabIndex = 2;
            start.Text = "開始";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 1;
            label1.Text = "頻率 (刻)";
            // 
            // repeat_ticks
            // 
            repeat_ticks.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repeat_ticks.Location = new Point(119, 6);
            repeat_ticks.Name = "repeat_ticks";
            repeat_ticks.Size = new Size(669, 43);
            repeat_ticks.TabIndex = 0;
            repeat_ticks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(start_key);
            tabPage2.Controls.Add(start_clicking);
            tabPage2.Controls.Add(clickstart_delay);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(click_repeat_seconds);
            tabPage2.Controls.Add(click_repeat_sec);
            tabPage2.Controls.Add(click_repeat_time);
            tabPage2.Controls.Add(click_repeat_times);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(click_ticks);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "連點器";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label6.Location = new Point(6, 156);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 22;
            label6.Text = "觸發按鍵";
            // 
            // start_key
            // 
            start_key.DropDownStyle = ComboBoxStyle.DropDownList;
            start_key.FlatStyle = FlatStyle.System;
            start_key.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            start_key.FormattingEnabled = true;
            start_key.Items.AddRange(new object[] { "手動", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            start_key.Location = new Point(121, 153);
            start_key.Name = "start_key";
            start_key.Size = new Size(663, 38);
            start_key.TabIndex = 21;
            start_key.SelectedIndexChanged += start_key_SelectedIndexChanged;
            // 
            // start_clicking
            // 
            start_clicking.FlatStyle = FlatStyle.System;
            start_clicking.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 136);
            start_clicking.Location = new Point(6, 322);
            start_clicking.Name = "start_clicking";
            start_clicking.Size = new Size(782, 88);
            start_clicking.TabIndex = 20;
            start_clicking.Text = "開始";
            start_clicking.UseVisualStyleBackColor = true;
            start_clicking.Click += start_clicking_Click;
            // 
            // clickstart_delay
            // 
            clickstart_delay.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickstart_delay.Location = new Point(119, 252);
            clickstart_delay.Name = "clickstart_delay";
            clickstart_delay.Size = new Size(669, 43);
            clickstart_delay.TabIndex = 19;
            clickstart_delay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(8, 257);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 18;
            label4.Text = "開始延遲";
            // 
            // click_repeat_seconds
            // 
            click_repeat_seconds.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            click_repeat_seconds.Location = new Point(159, 104);
            click_repeat_seconds.Name = "click_repeat_seconds";
            click_repeat_seconds.Size = new Size(629, 43);
            click_repeat_seconds.TabIndex = 17;
            click_repeat_seconds.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // click_repeat_sec
            // 
            click_repeat_sec.AutoSize = true;
            click_repeat_sec.FlatStyle = FlatStyle.System;
            click_repeat_sec.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            click_repeat_sec.Location = new Point(8, 108);
            click_repeat_sec.Name = "click_repeat_sec";
            click_repeat_sec.Size = new Size(145, 35);
            click_repeat_sec.TabIndex = 16;
            click_repeat_sec.Text = "重複秒數";
            click_repeat_sec.UseVisualStyleBackColor = true;
            click_repeat_sec.CheckedChanged += click_repeat_sec_CheckedChanged;
            // 
            // click_repeat_time
            // 
            click_repeat_time.AutoSize = true;
            click_repeat_time.Checked = true;
            click_repeat_time.FlatStyle = FlatStyle.System;
            click_repeat_time.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            click_repeat_time.Location = new Point(8, 59);
            click_repeat_time.Name = "click_repeat_time";
            click_repeat_time.Size = new Size(145, 35);
            click_repeat_time.TabIndex = 15;
            click_repeat_time.TabStop = true;
            click_repeat_time.Text = "重複次數";
            click_repeat_time.UseVisualStyleBackColor = true;
            click_repeat_time.CheckedChanged += click_repeat_time_CheckedChanged;
            // 
            // click_repeat_times
            // 
            click_repeat_times.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            click_repeat_times.Location = new Point(159, 55);
            click_repeat_times.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            click_repeat_times.Name = "click_repeat_times";
            click_repeat_times.Size = new Size(629, 43);
            click_repeat_times.TabIndex = 14;
            click_repeat_times.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(6, 11);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 13;
            label5.Text = "頻率 (刻)";
            // 
            // click_ticks
            // 
            click_ticks.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            click_ticks.Location = new Point(119, 6);
            click_ticks.Name = "click_ticks";
            click_ticks.Size = new Size(669, 43);
            click_ticks.TabIndex = 12;
            click_ticks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(start_walking_delay);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(running);
            tabPage3.Controls.Add(walking_sec);
            tabPage3.Controls.Add(start_walking);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(794, 416);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "自動走路器";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // start_walking_delay
            // 
            start_walking_delay.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start_walking_delay.Location = new Point(116, 279);
            start_walking_delay.Name = "start_walking_delay";
            start_walking_delay.Size = new Size(669, 43);
            start_walking_delay.TabIndex = 25;
            start_walking_delay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label7.Location = new Point(5, 284);
            label7.Name = "label7";
            label7.Size = new Size(109, 30);
            label7.TabIndex = 24;
            label7.Text = "開始延遲";
            // 
            // running
            // 
            running.AutoSize = true;
            running.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            running.Location = new Point(8, 55);
            running.Name = "running";
            running.Size = new Size(97, 40);
            running.TabIndex = 23;
            running.Text = "疾跑";
            running.UseVisualStyleBackColor = true;
            // 
            // walking_sec
            // 
            walking_sec.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            walking_sec.Location = new Point(8, 6);
            walking_sec.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            walking_sec.Name = "walking_sec";
            walking_sec.Size = new Size(776, 43);
            walking_sec.TabIndex = 22;
            walking_sec.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // start_walking
            // 
            start_walking.FlatStyle = FlatStyle.System;
            start_walking.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 136);
            start_walking.Location = new Point(3, 328);
            start_walking.Name = "start_walking";
            start_walking.Size = new Size(782, 88);
            start_walking.TabIndex = 21;
            start_walking.Text = "開始";
            start_walking.UseVisualStyleBackColor = true;
            start_walking.Click += start_walking_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(start_spamming);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(spam_delay);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(copy_use_text);
            tabPage4.Controls.Add(ctrlv_int);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(794, 416);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "全球通用洗版機器";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // start_spamming
            // 
            start_spamming.FlatStyle = FlatStyle.System;
            start_spamming.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 136);
            start_spamming.Location = new Point(2, 318);
            start_spamming.Name = "start_spamming";
            start_spamming.Size = new Size(782, 88);
            start_spamming.TabIndex = 27;
            start_spamming.Text = "開始 (延遲5秒)";
            start_spamming.UseVisualStyleBackColor = true;
            start_spamming.Click += start_spamming_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label9.Location = new Point(10, 114);
            label9.Name = "label9";
            label9.Size = new Size(107, 30);
            label9.TabIndex = 26;
            label9.Text = "頻率 (刻)";
            // 
            // spam_delay
            // 
            spam_delay.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spam_delay.Location = new Point(123, 109);
            spam_delay.Name = "spam_delay";
            spam_delay.Size = new Size(669, 43);
            spam_delay.TabIndex = 25;
            spam_delay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label8.Location = new Point(8, 11);
            label8.Name = "label8";
            label8.Size = new Size(109, 30);
            label8.TabIndex = 14;
            label8.Text = "洗版次數";
            // 
            // copy_use_text
            // 
            copy_use_text.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            copy_use_text.Location = new Point(8, 55);
            copy_use_text.Name = "copy_use_text";
            copy_use_text.PlaceholderText = "輸入要洗版的文字";
            copy_use_text.Size = new Size(776, 48);
            copy_use_text.TabIndex = 24;
            // 
            // ctrlv_int
            // 
            ctrlv_int.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlv_int.Location = new Point(123, 6);
            ctrlv_int.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            ctrlv_int.Name = "ctrlv_int";
            ctrlv_int.Size = new Size(661, 43);
            ctrlv_int.TabIndex = 23;
            ctrlv_int.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // minecraft_hack
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "minecraft_hack";
            Text = "Minecraft 物理外掛";
            FormClosing += minecraft_hack_FormClosing;
            Load += minecraft_hack_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)start_delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)repeat_sec).EndInit();
            ((System.ComponentModel.ISupportInitialize)repeat_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)repeat_ticks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clickstart_delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)click_repeat_seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)click_repeat_times).EndInit();
            ((System.ComponentModel.ISupportInitialize)click_ticks).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)start_walking_delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)walking_sec).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spam_delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctrlv_int).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private NumericUpDown repeat_ticks;
        private Button start;
        private NumericUpDown repeat_num;
        private RadioButton repeat_times;
        private RadioButton repeat_seconds;
        private NumericUpDown repeat_sec;
        private ComboBox start_action;
        private Label label2;
        private RadioButton repeat_click;
        private NumericUpDown start_delay;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tabPage2;
        private NumericUpDown clickstart_delay;
        private Label label4;
        private NumericUpDown click_repeat_seconds;
        private RadioButton click_repeat_sec;
        private RadioButton click_repeat_time;
        private NumericUpDown click_repeat_times;
        private Label label5;
        private NumericUpDown click_ticks;
        private Button start_clicking;
        private ComboBox start_key;
        private Label label6;
        private TabPage tabPage3;
        private Button start_walking;
        private NumericUpDown walking_sec;
        private CheckBox running;
        private NumericUpDown start_walking_delay;
        private Label label7;
        private TabPage tabPage4;
        private NumericUpDown ctrlv_int;
        private Label label9;
        private NumericUpDown spam_delay;
        private Label label8;
        private TextBox copy_use_text;
        private Button start_spamming;
    }
}