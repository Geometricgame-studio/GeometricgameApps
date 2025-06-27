namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class Mini_clock
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
            time = new Label();
            Exit = new Button();
            SuspendLayout();
            // 
            // time
            // 
            time.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time.Location = new Point(12, 9);
            time.Name = "time";
            time.Size = new Size(255, 113);
            time.TabIndex = 0;
            time.Text = "Date\r\ntime\r\n";
            time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.System;
            Exit.Location = new Point(12, 125);
            Exit.Name = "Exit";
            Exit.Size = new Size(255, 34);
            Exit.TabIndex = 1;
            Exit.Text = "返回(&B)";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Mini_clock
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 171);
            Controls.Add(Exit);
            Controls.Add(time);
            Name = "Mini_clock";
            Text = "小型時鐘";
            Load += Mini_clock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label time;
        private Button Exit;
    }
}