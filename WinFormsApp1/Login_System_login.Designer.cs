namespace All_tools_Form_Apps
{
    partial class Login_System_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_System_login));
            label6 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            Colorbox1 = new Label();
            chkShowpassword = new CheckBox();
            txtpassword = new TextBox();
            label3 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            exit = new Button();
            ellipseContorl1 = new Custom_class.EllipseContorl();
            stay_login = new CheckBox();
            Loading_pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Loading_pic).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(883, 452);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 25;
            label6.Text = "創建一個";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(869, 424);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 24;
            label5.Text = "還沒有帳戶?";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(930, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(284, 65);
            btnClear.TabIndex = 23;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(634, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 65);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Colorbox1
            // 
            Colorbox1.BackColor = SystemColors.ControlText;
            Colorbox1.Location = new Point(616, 73);
            Colorbox1.Name = "Colorbox1";
            Colorbox1.Size = new Size(2, 398);
            Colorbox1.TabIndex = 21;
            // 
            // chkShowpassword
            // 
            chkShowpassword.AutoSize = true;
            chkShowpassword.Cursor = Cursors.Hand;
            chkShowpassword.FlatStyle = FlatStyle.System;
            chkShowpassword.Location = new Point(634, 263);
            chkShowpassword.Name = "chkShowpassword";
            chkShowpassword.Size = new Size(134, 33);
            chkShowpassword.TabIndex = 20;
            chkShowpassword.Text = "顯示密碼";
            chkShowpassword.UseVisualStyleBackColor = true;
            chkShowpassword.CheckedChanged += chkShowpassword_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.ForeColor = SystemColors.ControlText;
            txtpassword.Location = new Point(634, 202);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(574, 27);
            txtpassword.TabIndex = 17;
            txtpassword.KeyPress += txtpassword_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(634, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 16;
            label3.Text = "密碼";
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.ForeColor = SystemColors.ControlText;
            txtusername.Location = new Point(634, 91);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(574, 27);
            txtusername.TabIndex = 15;
            txtusername.KeyPress += txtusername_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(634, 60);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 14;
            label2.Text = "用戶名稱";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 84, 174);
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(553, 120);
            label1.TabIndex = 13;
            label1.Text = "開始使用\r\nGeometricgame Apps";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.System;
            exit.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Black;
            exit.Location = new Point(1102, 498);
            exit.Name = "exit";
            exit.Size = new Size(112, 42);
            exit.TabIndex = 26;
            exit.Text = "離開";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // ellipseContorl1
            // 
            ellipseContorl1.CornerRadius = 25;
            ellipseContorl1.TargetControl = this;
            // 
            // stay_login
            // 
            stay_login.AutoSize = true;
            stay_login.Checked = true;
            stay_login.CheckState = CheckState.Checked;
            stay_login.FlatStyle = FlatStyle.System;
            stay_login.Location = new Point(634, 301);
            stay_login.Name = "stay_login";
            stay_login.Size = new Size(134, 33);
            stay_login.TabIndex = 27;
            stay_login.Text = "保持登入";
            stay_login.UseVisualStyleBackColor = true;
            // 
            // Loading_pic
            // 
            Loading_pic.Image = (Image)resources.GetObject("Loading_pic.Image");
            Loading_pic.Location = new Point(12, 183);
            Loading_pic.Name = "Loading_pic";
            Loading_pic.Size = new Size(598, 113);
            Loading_pic.SizeMode = PictureBoxSizeMode.Zoom;
            Loading_pic.TabIndex = 28;
            Loading_pic.TabStop = false;
            Loading_pic.Visible = false;
            // 
            // Login_System_login
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 552);
            Controls.Add(Loading_pic);
            Controls.Add(stay_login);
            Controls.Add(exit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(Colorbox1);
            Controls.Add(chkShowpassword);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login_System_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登入";
            Load += Login_System_login_Load;
            ((System.ComponentModel.ISupportInitialize)Loading_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button btnClear;
        private Button btnLogin;
        private Label Colorbox1;
        private CheckBox chkShowpassword;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtusername;
        private Label label2;
        private Label label1;
        private Button exit;
        private Custom_class.EllipseContorl ellipseContorl1;
        private CheckBox stay_login;
        private PictureBox Loading_pic;
    }
}