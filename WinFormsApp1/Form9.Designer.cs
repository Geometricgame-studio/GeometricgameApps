namespace All_tools_Form_Apps
{
    partial class Form9
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
            Title = new Label();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            seven = new Button();
            other_need = new Button();
            Exit = new Button();
            Time = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(1883, 246);
            Title.TabIndex = 0;
            Title.Text = "歡迎來到 這隻喵飯店 新店店!!!\r\n以下是現有的服務:";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // one
            // 
            one.FlatStyle = FlatStyle.System;
            one.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            one.Location = new Point(12, 286);
            one.Name = "one";
            one.Size = new Size(397, 162);
            one.TabIndex = 1;
            one.Text = "洗碗服務";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // two
            // 
            two.FlatStyle = FlatStyle.System;
            two.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            two.Location = new Point(415, 286);
            two.Name = "two";
            two.Size = new Size(412, 162);
            two.TabIndex = 2;
            two.Text = "折衣服服務";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // three
            // 
            three.FlatStyle = FlatStyle.System;
            three.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            three.Location = new Point(833, 286);
            three.Name = "three";
            three.Size = new Size(412, 162);
            three.TabIndex = 3;
            three.Text = "洗衣服服務";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // four
            // 
            four.FlatStyle = FlatStyle.System;
            four.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            four.Location = new Point(1251, 286);
            four.Name = "four";
            four.Size = new Size(412, 162);
            four.TabIndex = 4;
            four.Text = "頂級按摩服務";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // five
            // 
            five.FlatStyle = FlatStyle.System;
            five.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            five.Location = new Point(12, 454);
            five.Name = "five";
            five.Size = new Size(397, 162);
            five.TabIndex = 5;
            five.Text = "開啟時鐘(&C)";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.FlatStyle = FlatStyle.System;
            six.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            six.Location = new Point(415, 454);
            six.Name = "six";
            six.Size = new Size(412, 162);
            six.TabIndex = 6;
            six.Text = "洗頭服務";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // seven
            // 
            seven.FlatStyle = FlatStyle.System;
            seven.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            seven.Location = new Point(833, 454);
            seven.Name = "seven";
            seven.Size = new Size(412, 162);
            seven.TabIndex = 7;
            seven.Text = "說故事服務";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // other_need
            // 
            other_need.FlatStyle = FlatStyle.System;
            other_need.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            other_need.Location = new Point(1251, 454);
            other_need.Name = "other_need";
            other_need.Size = new Size(412, 162);
            other_need.TabIndex = 8;
            other_need.Text = "其他需求...";
            other_need.UseVisualStyleBackColor = true;
            other_need.Click += other_need_Click;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.Control;
            Exit.FlatStyle = FlatStyle.System;
            Exit.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Exit.ForeColor = SystemColors.ControlText;
            Exit.Location = new Point(1669, 286);
            Exit.Name = "Exit";
            Exit.Size = new Size(226, 330);
            Exit.TabIndex = 9;
            Exit.Text = "退房操作";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Time
            // 
            Time.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(12, 766);
            Time.Name = "Time";
            Time.Size = new Size(1883, 284);
            Time.TabIndex = 10;
            Time.Text = "NOW TIME";
            Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1907, 1059);
            Controls.Add(Time);
            Controls.Add(Exit);
            Controls.Add(other_need);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(Title);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "飯店服務系統";
            Load += Form9_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button other_need;
        private Button Exit;
        private Label Time;
    }
}