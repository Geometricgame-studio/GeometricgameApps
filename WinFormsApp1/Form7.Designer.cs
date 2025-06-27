namespace All_tools_Form_Apps
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            form_account = new TextBox();
            label1 = new Label();
            form_pass = new TextBox();
            label2 = new Label();
            title = new TextBox();
            label3 = new Label();
            label4 = new Label();
            text = new TextBox();
            label5 = new Label();
            to_account = new TextBox();
            Send = new Button();
            Cancle = new Button();
            SuspendLayout();
            // 
            // form_account
            // 
            form_account.Location = new Point(12, 40);
            form_account.Name = "form_account";
            form_account.PlaceholderText = "Sample@gmail.com";
            form_account.Size = new Size(776, 30);
            form_account.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 1;
            label1.Text = "寄件人";
            // 
            // form_pass
            // 
            form_pass.Location = new Point(12, 104);
            form_pass.Name = "form_pass";
            form_pass.PlaceholderText = "1234567890";
            form_pass.Size = new Size(776, 30);
            form_pass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 3;
            label2.Text = "寄件人帳戶的密碼";
            // 
            // title
            // 
            title.Location = new Point(12, 232);
            title.Name = "title";
            title.PlaceholderText = "標題";
            title.Size = new Size(776, 30);
            title.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(12, 201);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 5;
            label3.Text = "郵件標題";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(12, 268);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 6;
            label4.Text = "郵件內容";
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text.Location = new Point(12, 303);
            text.Multiline = true;
            text.Name = "text";
            text.PlaceholderText = "內容";
            text.Size = new Size(776, 167);
            text.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(12, 137);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 8;
            label5.Text = "收件人";
            // 
            // to_account
            // 
            to_account.Location = new Point(12, 168);
            to_account.Name = "to_account";
            to_account.PlaceholderText = "To@gmail.com";
            to_account.Size = new Size(776, 30);
            to_account.TabIndex = 9;
            // 
            // Send
            // 
            Send.FlatStyle = FlatStyle.System;
            Send.Location = new Point(676, 476);
            Send.Name = "Send";
            Send.Size = new Size(112, 34);
            Send.TabIndex = 10;
            Send.Text = "寄送";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Cancle
            // 
            Cancle.FlatStyle = FlatStyle.System;
            Cancle.Location = new Point(558, 476);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(112, 34);
            Cancle.TabIndex = 11;
            Cancle.Text = "取消";
            Cancle.UseVisualStyleBackColor = true;
            Cancle.Click += Cancle_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(Cancle);
            Controls.Add(Send);
            Controls.Add(to_account);
            Controls.Add(label5);
            Controls.Add(text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(title);
            Controls.Add(label2);
            Controls.Add(form_pass);
            Controls.Add(label1);
            Controls.Add(form_account);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "寄送 Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox form_account;
        private Label label1;
        private TextBox form_pass;
        private Label label2;
        private TextBox title;
        private Label label3;
        private Label label4;
        private TextBox text;
        private Label label5;
        private TextBox to_account;
        private Button Send;
        private Button Cancle;
    }
}