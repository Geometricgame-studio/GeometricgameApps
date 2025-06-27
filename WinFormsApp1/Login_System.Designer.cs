namespace All_tools_Form_Apps
{
    partial class Login_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_System));
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            txtcompassword = new TextBox();
            label4 = new Label();
            chkShowpassword = new CheckBox();
            Colorbox1 = new Label();
            btnRegister = new Button();
            btnClear = new Button();
            label5 = new Label();
            label6 = new Label();
            ellipseContorl1 = new Custom_class.EllipseContorl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 84, 174);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(553, 120);
            label1.TabIndex = 0;
            label1.Text = "開始使用\r\nGeometricgame Apps";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(634, 83);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "用戶名稱";
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.ForeColor = SystemColors.ControlText;
            txtusername.Location = new Point(634, 114);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(574, 27);
            txtusername.TabIndex = 2;
            txtusername.KeyPress += txtusername_KeyPress;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.ForeColor = SystemColors.ControlText;
            txtpassword.Location = new Point(634, 225);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(574, 27);
            txtpassword.TabIndex = 4;
            txtpassword.KeyPress += txtpassword_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(634, 194);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 3;
            label3.Text = "密碼";
            // 
            // txtcompassword
            // 
            txtcompassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtcompassword.BackColor = Color.FromArgb(230, 231, 233);
            txtcompassword.BorderStyle = BorderStyle.None;
            txtcompassword.ForeColor = SystemColors.ControlText;
            txtcompassword.Location = new Point(634, 300);
            txtcompassword.Name = "txtcompassword";
            txtcompassword.PasswordChar = '•';
            txtcompassword.Size = new Size(574, 27);
            txtcompassword.TabIndex = 6;
            txtcompassword.KeyPress += txtcompassword_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(634, 269);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 5;
            label4.Text = "確認密碼";
            // 
            // chkShowpassword
            // 
            chkShowpassword.AutoSize = true;
            chkShowpassword.Cursor = Cursors.Hand;
            chkShowpassword.Location = new Point(634, 347);
            chkShowpassword.Name = "chkShowpassword";
            chkShowpassword.Size = new Size(122, 32);
            chkShowpassword.TabIndex = 7;
            chkShowpassword.Text = "顯示密碼";
            chkShowpassword.UseVisualStyleBackColor = true;
            chkShowpassword.CheckedChanged += chkShowpassword_CheckedChanged;
            // 
            // Colorbox1
            // 
            Colorbox1.BackColor = SystemColors.ControlText;
            Colorbox1.Location = new Point(616, 71);
            Colorbox1.Name = "Colorbox1";
            Colorbox1.Size = new Size(2, 398);
            Colorbox1.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(634, 404);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(290, 65);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "註冊帳戶";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(930, 404);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(284, 65);
            btnClear.TabIndex = 10;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(830, 472);
            label5.Name = "label5";
            label5.Size = new Size(189, 28);
            label5.TabIndex = 11;
            label5.Text = "已經有一個帳戶了?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(845, 500);
            label6.Name = "label6";
            label6.Size = new Size(150, 28);
            label6.TabIndex = 12;
            label6.Text = "回到 登入 頁面";
            label6.Click += label6_Click;
            // 
            // ellipseContorl1
            // 
            ellipseContorl1.CornerRadius = 25;
            ellipseContorl1.TargetControl = this;
            // 
            // Login_System
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 552);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(Colorbox1);
            Controls.Add(chkShowpassword);
            Controls.Add(txtcompassword);
            Controls.Add(label4);
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
            Name = "Login_System";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "註冊帳戶";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtcompassword;
        private Label label4;
        private CheckBox chkShowpassword;
        private Label Colorbox1;
        private Button btnRegister;
        private Button btnClear;
        private Label label5;
        private Label label6;
        private Custom_class.EllipseContorl ellipseContorl1;
    }
}