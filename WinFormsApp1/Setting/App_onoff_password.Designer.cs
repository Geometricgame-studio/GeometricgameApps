namespace All_tools_Form_Apps.Setting
{
    partial class App_onoff_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_onoff_password));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtpassword = new TextBox();
            enter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(259, 12);
            label1.Name = "label1";
            label1.Size = new Size(444, 132);
            label1.TabIndex = 1;
            label1.Text = "應用設定\r\n需要密碼才能繼續\r\n";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtpassword.Location = new Point(12, 247);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.PlaceholderText = "輸入密碼以繼續";
            txtpassword.Size = new Size(657, 48);
            txtpassword.TabIndex = 2;
            // 
            // enter
            // 
            enter.FlatStyle = FlatStyle.System;
            enter.Location = new Point(675, 247);
            enter.Name = "enter";
            enter.Size = new Size(113, 48);
            enter.TabIndex = 3;
            enter.Text = "繼續";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // App_onoff_password
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 314);
            Controls.Add(enter);
            Controls.Add(txtpassword);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(822, 370);
            MinimizeBox = false;
            MinimumSize = new Size(822, 370);
            Name = "App_onoff_password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "應用設定 請輸入密碼";
            Load += App_onoff_password_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtpassword;
        private Button enter;
    }
}