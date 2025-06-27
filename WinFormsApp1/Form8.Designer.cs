namespace All_tools_Form_Apps
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            Good = new Button();
            Bad = new Button();
            title = new Label();
            scores = new Label();
            entered_score = new NumericUpDown();
            label1 = new Label();
            Enter_score = new Button();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)entered_score).BeginInit();
            SuspendLayout();
            // 
            // Good
            // 
            Good.AutoSize = true;
            Good.FlatStyle = FlatStyle.System;
            Good.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Good.Location = new Point(69, 123);
            Good.Name = "Good";
            Good.Size = new Size(660, 105);
            Good.TabIndex = 0;
            Good.Text = "好";
            Good.UseVisualStyleBackColor = true;
            Good.Click += Good_Click;
            // 
            // Bad
            // 
            Bad.AutoSize = true;
            Bad.FlatStyle = FlatStyle.System;
            Bad.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Bad.Location = new Point(69, 234);
            Bad.Name = "Bad";
            Bad.Size = new Size(660, 105);
            Bad.TabIndex = 1;
            Bad.Text = "壞";
            Bad.UseVisualStyleBackColor = true;
            Bad.Click += Bad_Click;
            // 
            // title
            // 
            title.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(776, 101);
            title.TabIndex = 2;
            title.Text = "請回答以下問題";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scores
            // 
            scores.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            scores.Location = new Point(12, 110);
            scores.Name = "scores";
            scores.Size = new Size(776, 192);
            scores.TabIndex = 3;
            scores.Text = "結果";
            scores.TextAlign = ContentAlignment.MiddleCenter;
            scores.Visible = false;
            // 
            // entered_score
            // 
            entered_score.Location = new Point(197, 376);
            entered_score.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            entered_score.Name = "entered_score";
            entered_score.Size = new Size(404, 30);
            entered_score.TabIndex = 4;
            entered_score.Value = new decimal(new int[] { 10, 0, 0, 0 });
            entered_score.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 248);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 5;
            // 
            // Enter_score
            // 
            Enter_score.FlatStyle = FlatStyle.System;
            Enter_score.Location = new Point(250, 338);
            Enter_score.Name = "Enter_score";
            Enter_score.Size = new Size(302, 34);
            Enter_score.TabIndex = 6;
            Enter_score.Text = "如果系統預測錯誤，請按此。";
            Enter_score.UseVisualStyleBackColor = true;
            Enter_score.Visible = false;
            Enter_score.Click += Enter_score_Click;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.System;
            Exit.Location = new Point(343, 298);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 7;
            Exit.Text = "結束";
            Exit.UseVisualStyleBackColor = true;
            Exit.Visible = false;
            Exit.Click += Exit_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 413);
            Controls.Add(Exit);
            Controls.Add(Enter_score);
            Controls.Add(label1);
            Controls.Add(entered_score);
            Controls.Add(scores);
            Controls.Add(title);
            Controls.Add(Bad);
            Controls.Add(Good);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "喵星系統";
            ((System.ComponentModel.ISupportInitialize)entered_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Good;
        private Button Bad;
        private Label title;
        private Label scores;
        private NumericUpDown entered_score;
        private Label label1;
        private Button Enter_score;
        private Button Exit;
    }
}