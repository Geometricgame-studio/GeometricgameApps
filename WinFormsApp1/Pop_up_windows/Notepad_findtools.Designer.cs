namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class Notepad_findtools
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
            Next = new Button();
            Back = new Button();
            Exit = new Button();
            title = new Label();
            textBox1 = new TextBox();
            number = new Label();
            SuspendLayout();
            // 
            // Next
            // 
            Next.FlatStyle = FlatStyle.System;
            Next.Location = new Point(199, 173);
            Next.Name = "Next";
            Next.Size = new Size(112, 34);
            Next.TabIndex = 0;
            Next.Text = "下一個";
            Next.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            Back.FlatStyle = FlatStyle.System;
            Back.Location = new Point(12, 173);
            Back.Name = "Back";
            Back.Size = new Size(112, 34);
            Back.TabIndex = 1;
            Back.Text = "上一個";
            Back.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.System;
            Exit.Location = new Point(643, 173);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 2;
            Exit.Text = "關閉";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(164, 46);
            title.TabIndex = 3;
            title.Text = "尋找內容";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(12, 68);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "請輸入想要尋找的文字";
            textBox1.Size = new Size(743, 48);
            textBox1.TabIndex = 4;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            number.Location = new Point(130, 177);
            number.Name = "number";
            number.Size = new Size(63, 30);
            number.TabIndex = 5;
            number.Text = "0 / 0";
            // 
            // Notepad_findtools
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 219);
            Controls.Add(number);
            Controls.Add(textBox1);
            Controls.Add(title);
            Controls.Add(Exit);
            Controls.Add(Back);
            Controls.Add(Next);
            Name = "Notepad_findtools";
            Text = "尋找";
            Load += Notepad_findtools_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Next;
        private Button Back;
        private Button Exit;
        private Label title;
        private TextBox textBox1;
        private Label number;
    }
}