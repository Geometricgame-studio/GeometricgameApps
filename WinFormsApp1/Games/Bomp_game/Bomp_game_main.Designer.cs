namespace All_tools_Form_Apps.Games.Bomp_game
{
    partial class Bomp_game_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bomp_game_main));
            button1 = new Button();
            exit = new Button();
            ball_count = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 43);
            button1.Name = "button1";
            button1.Size = new Size(291, 87);
            button1.TabIndex = 0;
            button1.Text = "生成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // exit
            // 
            exit.Location = new Point(12, 136);
            exit.Name = "exit";
            exit.Size = new Size(291, 53);
            exit.TabIndex = 1;
            exit.Text = "離開遊戲";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // ball_count
            // 
            ball_count.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ball_count.Location = new Point(12, 9);
            ball_count.Name = "ball_count";
            ball_count.Size = new Size(291, 34);
            ball_count.TabIndex = 2;
            ball_count.Text = "Balls Counter";
            ball_count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bomp_game_main
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 201);
            Controls.Add(ball_count);
            Controls.Add(exit);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bomp_game_main";
            Text = "彈力遊戲";
            FormClosing += Bomp_game_main_FormClosing;
            Load += Bomp_game_main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button exit;
        private Label ball_count;
    }
}