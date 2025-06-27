namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class Svesystem_password
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
            label1 = new Label();
            password = new TextBox();
            Enter = new Button();
            Exit = new Button();
            reserve = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(593, 50);
            label1.TabIndex = 0;
            label1.Text = "如要繼續，請輸入房號";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            password.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(12, 80);
            password.Name = "password";
            password.Size = new Size(593, 43);
            password.TabIndex = 1;
            // 
            // Enter
            // 
            Enter.FlatStyle = FlatStyle.System;
            Enter.Location = new Point(493, 144);
            Enter.Name = "Enter";
            Enter.Size = new Size(112, 34);
            Enter.TabIndex = 2;
            Enter.Text = "繼續";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.System;
            Exit.Location = new Point(375, 144);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 3;
            Exit.Text = "回到主畫面";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // reserve
            // 
            reserve.FlatStyle = FlatStyle.System;
            reserve.Location = new Point(253, 144);
            reserve.Name = "reserve";
            reserve.Size = new Size(116, 34);
            reserve.TabIndex = 4;
            reserve.Text = "預約";
            reserve.UseVisualStyleBackColor = true;
            reserve.Click += reserve_Click;
            // 
            // Svesystem_password
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 190);
            Controls.Add(reserve);
            Controls.Add(Exit);
            Controls.Add(Enter);
            Controls.Add(password);
            Controls.Add(label1);
            Name = "Svesystem_password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "服務系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox password;
        private Button Enter;
        private Button Exit;
        private Button reserve;
    }
}