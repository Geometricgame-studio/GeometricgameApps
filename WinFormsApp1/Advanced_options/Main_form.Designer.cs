namespace All_tools_Form_Apps.Advanced_options
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            Title = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            pictureBox6 = new PictureBox();
            button6 = new Button();
            pictureBox7 = new PictureBox();
            button7 = new Button();
            process1 = new System.Diagnostics.Process();
            button8 = new Button();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Title.Location = new Point(80, 39);
            Title.Name = "Title";
            Title.Size = new Size(327, 91);
            Title.TabIndex = 0;
            Title.Text = "進階選項";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(203, 187);
            button1.Name = "button1";
            button1.Size = new Size(399, 101);
            button1.TabIndex = 1;
            button1.Text = "繼續";
            button1.UseVisualStyleBackColor = false;
            button1.Click += continue_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(203, 315);
            button2.Name = "button2";
            button2.Size = new Size(399, 101);
            button2.TabIndex = 3;
            button2.Text = "以未登入的方式進入系統";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(622, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(728, 187);
            button3.Name = "button3";
            button3.Size = new Size(399, 101);
            button3.TabIndex = 5;
            button3.Text = "離開系統";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(622, 315);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 101);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button4.Location = new Point(728, 315);
            button4.Name = "button4";
            button4.Size = new Size(399, 101);
            button4.TabIndex = 7;
            button4.Text = "開啟命令提示字元";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(622, 446);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 101);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button5.Location = new Point(728, 446);
            button5.Name = "button5";
            button5.Size = new Size(399, 101);
            button5.TabIndex = 9;
            button5.Text = "命令提示字元(Windows)";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(97, 446);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 101);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button6.Location = new Point(203, 446);
            button6.Name = "button6";
            button6.Size = new Size(399, 101);
            button6.TabIndex = 11;
            button6.Text = "執行應用程式";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(97, 576);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 101);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button7.Location = new Point(203, 576);
            button7.Name = "button7";
            button7.Size = new Size(399, 101);
            button7.TabIndex = 13;
            button7.Text = "更新應用程式";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button8.Location = new Point(728, 576);
            button8.Name = "button8";
            button8.Size = new Size(399, 101);
            button8.TabIndex = 15;
            button8.Text = "Debug 操作 (危險!!!)";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(622, 576);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 101);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1548, 726);
            Controls.Add(pictureBox8);
            Controls.Add(button8);
            Controls.Add(pictureBox7);
            Controls.Add(button7);
            Controls.Add(pictureBox6);
            Controls.Add(button6);
            Controls.Add(pictureBox5);
            Controls.Add(button5);
            Controls.Add(pictureBox4);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(Title);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Main_form";
            Text = "進階選項";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox4;
        private Button button4;
        private PictureBox pictureBox5;
        private Button button5;
        private PictureBox pictureBox6;
        private Button button6;
        private PictureBox pictureBox7;
        private Button button7;
        private System.Diagnostics.Process process1;
        private PictureBox pictureBox8;
        private Button button8;
    }
}