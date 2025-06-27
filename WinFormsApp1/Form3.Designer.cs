namespace All_tools_Form_Apps
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            shutdownmode = new ComboBox();
            timer = new Label();
            text1 = new Label();
            Start = new Button();
            hr = new ComboBox();
            minute = new ComboBox();
            second = new ComboBox();
            close_password = new TextBox();
            password_help = new Button();
            text2 = new Label();
            password_update = new Label();
            progressBar = new Custom_class.Custom_ProgessBar();
            Target = new ComboBox();
            SuspendLayout();
            // 
            // shutdownmode
            // 
            shutdownmode.DisplayMember = "3";
            shutdownmode.DropDownStyle = ComboBoxStyle.DropDownList;
            shutdownmode.FormattingEnabled = true;
            shutdownmode.Items.AddRange(new object[] { "關機", "重新啟動 (預設)" });
            shutdownmode.Location = new Point(9, 202);
            shutdownmode.Name = "shutdownmode";
            shutdownmode.Size = new Size(1105, 31);
            shutdownmode.TabIndex = 3;
            // 
            // timer
            // 
            timer.AutoSize = true;
            timer.Font = new Font("Century Gothic", 52F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timer.Location = new Point(9, 9);
            timer.Name = "timer";
            timer.Size = new Size(319, 123);
            timer.TabIndex = 4;
            timer.Text = "Timer";
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(14, 241);
            text1.Name = "text1";
            text1.Size = new Size(330, 23);
            text1.TabIndex = 11;
            text1.Text = "輸入 時                  分                           秒";
            // 
            // Start
            // 
            Start.Location = new Point(468, 267);
            Start.Name = "Start";
            Start.Size = new Size(112, 34);
            Start.TabIndex = 12;
            Start.Text = "開始";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // hr
            // 
            hr.FormattingEnabled = true;
            hr.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            hr.Location = new Point(9, 267);
            hr.Name = "hr";
            hr.Size = new Size(147, 31);
            hr.TabIndex = 13;
            // 
            // minute
            // 
            minute.FormattingEnabled = true;
            minute.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            minute.Location = new Point(162, 267);
            minute.Name = "minute";
            minute.Size = new Size(147, 31);
            minute.TabIndex = 14;
            // 
            // second
            // 
            second.FormattingEnabled = true;
            second.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            second.Location = new Point(315, 267);
            second.Name = "second";
            second.Size = new Size(147, 31);
            second.TabIndex = 15;
            // 
            // close_password
            // 
            close_password.AccessibleRole = AccessibleRole.Alert;
            close_password.Cursor = Cursors.IBeam;
            close_password.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            close_password.Location = new Point(78, 378);
            close_password.Name = "close_password";
            close_password.PlaceholderText = "輸入驗證碼來關閉程式";
            close_password.Size = new Size(300, 38);
            close_password.TabIndex = 17;
            close_password.TextChanged += close_password_TextChanged;
            // 
            // password_help
            // 
            password_help.Location = new Point(384, 381);
            password_help.Name = "password_help";
            password_help.Size = new Size(85, 34);
            password_help.TabIndex = 18;
            password_help.Text = "幫助";
            password_help.UseVisualStyleBackColor = true;
            password_help.Click += password_help_Click;
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new Point(14, 351);
            text2.Name = "text2";
            text2.Size = new Size(194, 23);
            text2.TabIndex = 19;
            text2.Text = "輸入驗證碼來關閉程式:";
            // 
            // password_update
            // 
            password_update.AutoSize = true;
            password_update.BackColor = SystemColors.Control;
            password_update.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_update.Location = new Point(12, 374);
            password_update.Name = "password_update";
            password_update.Size = new Size(62, 56);
            password_update.TabIndex = 20;
            password_update.Text = "--";
            // 
            // progressBar
            // 
            progressBar.ChannelColor = Color.Red;
            progressBar.ChannelHeight = 15;
            progressBar.ForeBackColor = Color.Transparent;
            progressBar.ForeColor = Color.Black;
            progressBar.Location = new Point(9, 162);
            progressBar.Name = "progressBar";
            progressBar.ShowValue = Custom_class.TextPosition.None;
            progressBar.Size = new Size(1105, 34);
            progressBar.SliderColor = Color.LightGreen;
            progressBar.SliderHeight = 15;
            progressBar.TabIndex = 21;
            // 
            // Target
            // 
            Target.DisplayMember = "3";
            Target.DropDownStyle = ComboBoxStyle.DropDownList;
            Target.FormattingEnabled = true;
            Target.Items.AddRange(new object[] { "Windows 作業系統 (預設)", "Blaze OS" });
            Target.Location = new Point(779, 267);
            Target.Name = "Target";
            Target.Size = new Size(335, 31);
            Target.TabIndex = 22;
            Target.SelectedIndexChanged += Target_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 419);
            Controls.Add(Target);
            Controls.Add(progressBar);
            Controls.Add(password_update);
            Controls.Add(text2);
            Controls.Add(password_help);
            Controls.Add(close_password);
            Controls.Add(second);
            Controls.Add(minute);
            Controls.Add(hr);
            Controls.Add(Start);
            Controls.Add(text1);
            Controls.Add(timer);
            Controls.Add(shutdownmode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "計時關機系統";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox shutdownmode;
        private Label timer;
        private Label text1;
        private Button Start;
        private ComboBox hr;
        private ComboBox minute;
        private ComboBox second;
        private TextBox close_password;
        private Button password_help;
        private Label text2;
        private Label password_update;
        private Custom_class.Custom_ProgessBar progressBar;
        private ComboBox Target;
    }
}