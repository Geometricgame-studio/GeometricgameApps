namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class Cattest_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cattest_password));
            title = new Label();
            password = new TextBox();
            enter = new Button();
            Cancle = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(690, 41);
            title.TabIndex = 0;
            title.Text = "此頁面不對外開放，如要繼續，請輸入驗證碼。\r\n";
            // 
            // password
            // 
            password.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            password.Location = new Point(12, 90);
            password.Name = "password";
            password.PlaceholderText = "在此輸入驗證碼";
            password.Size = new Size(680, 38);
            password.TabIndex = 1;
            // 
            // enter
            // 
            enter.FlatStyle = FlatStyle.System;
            enter.Location = new Point(580, 137);
            enter.Name = "enter";
            enter.Size = new Size(112, 34);
            enter.TabIndex = 2;
            enter.Text = "繼續";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // Cancle
            // 
            Cancle.FlatStyle = FlatStyle.System;
            Cancle.Location = new Point(462, 137);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(112, 34);
            Cancle.TabIndex = 3;
            Cancle.Text = "返回主畫面";
            Cancle.UseVisualStyleBackColor = true;
            Cancle.Click += Cancle_Click;
            // 
            // Cattest_password
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 183);
            Controls.Add(Cancle);
            Controls.Add(enter);
            Controls.Add(password);
            Controls.Add(title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cattest_password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "評分系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox password;
        private Button enter;
        private Button Cancle;
    }
}