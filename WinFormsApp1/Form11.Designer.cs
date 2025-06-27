namespace All_tools_Form_Apps
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            time = new Label();
            Change_font = new Button();
            fontDialog1 = new FontDialog();
            Mini_window = new Button();
            Change_color = new Button();
            exit = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // time
            // 
            time.Font = new Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time.Location = new Point(12, 9);
            time.Name = "time";
            time.Size = new Size(765, 306);
            time.TabIndex = 0;
            time.Text = "TIME";
            time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Change_font
            // 
            Change_font.FlatStyle = FlatStyle.System;
            Change_font.Location = new Point(12, 318);
            Change_font.Name = "Change_font";
            Change_font.Size = new Size(187, 34);
            Change_font.TabIndex = 1;
            Change_font.Text = "變更字體(&F)";
            Change_font.UseVisualStyleBackColor = true;
            Change_font.Click += Change_font_Click;
            // 
            // Mini_window
            // 
            Mini_window.FlatStyle = FlatStyle.System;
            Mini_window.Location = new Point(205, 318);
            Mini_window.Name = "Mini_window";
            Mini_window.Size = new Size(187, 34);
            Mini_window.TabIndex = 2;
            Mini_window.Text = "保持在頂層(&L)";
            Mini_window.UseVisualStyleBackColor = true;
            Mini_window.Click += Mini_window_Click;
            // 
            // Change_color
            // 
            Change_color.FlatStyle = FlatStyle.System;
            Change_color.Location = new Point(398, 318);
            Change_color.Name = "Change_color";
            Change_color.Size = new Size(187, 34);
            Change_color.TabIndex = 3;
            Change_color.Text = "變更顏色(&C)";
            Change_color.UseVisualStyleBackColor = true;
            Change_color.Click += Change_color_Click;
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.System;
            exit.Location = new Point(590, 318);
            exit.Name = "exit";
            exit.Size = new Size(187, 34);
            exit.TabIndex = 4;
            exit.Text = "離開(&E)";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 364);
            Controls.Add(exit);
            Controls.Add(Change_color);
            Controls.Add(Mini_window);
            Controls.Add(Change_font);
            Controls.Add(time);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form11";
            Text = "時鐘";
            Load += Form11_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label time;
        private Button Change_font;
        private FontDialog fontDialog1;
        private Button Mini_window;
        private Button Change_color;
        private Button exit;
        private ColorDialog colorDialog1;
    }
}