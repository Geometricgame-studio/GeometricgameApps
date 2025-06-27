namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class SveAddsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SveAddsystem));
            title = new Label();
            gmail = new TextBox();
            roomnum = new TextBox();
            roomnum_help = new Button();
            Reserve = new Button();
            cancle = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(776, 52);
            title.TabIndex = 0;
            title.Text = "預約這隻喵飯店";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gmail
            // 
            gmail.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gmail.Location = new Point(12, 64);
            gmail.Name = "gmail";
            gmail.PlaceholderText = "Enter your Gmail";
            gmail.Size = new Size(776, 49);
            gmail.TabIndex = 1;
            gmail.TextChanged += gmail_TextChanged;
            // 
            // roomnum
            // 
            roomnum.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomnum.Location = new Point(12, 119);
            roomnum.Name = "roomnum";
            roomnum.PlaceholderText = "Enter room number you want to stay in";
            roomnum.Size = new Size(693, 49);
            roomnum.TabIndex = 2;
            roomnum.TextChanged += roomnum_TextChanged;
            // 
            // roomnum_help
            // 
            roomnum_help.FlatStyle = FlatStyle.System;
            roomnum_help.Location = new Point(711, 119);
            roomnum_help.Name = "roomnum_help";
            roomnum_help.Size = new Size(77, 49);
            roomnum_help.TabIndex = 3;
            roomnum_help.Text = "幫助";
            roomnum_help.UseVisualStyleBackColor = true;
            roomnum_help.Click += roomnum_help_Click;
            // 
            // Reserve
            // 
            Reserve.FlatStyle = FlatStyle.System;
            Reserve.Location = new Point(670, 235);
            Reserve.Name = "Reserve";
            Reserve.Size = new Size(118, 48);
            Reserve.TabIndex = 4;
            Reserve.Text = "預約";
            Reserve.UseVisualStyleBackColor = true;
            Reserve.Click += Reserve_Click;
            // 
            // cancle
            // 
            cancle.FlatStyle = FlatStyle.System;
            cancle.Location = new Point(546, 235);
            cancle.Name = "cancle";
            cancle.Size = new Size(118, 48);
            cancle.TabIndex = 5;
            cancle.Text = "取消";
            cancle.UseVisualStyleBackColor = true;
            cancle.Click += cancle_Click;
            // 
            // SveAddsystem
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 295);
            Controls.Add(cancle);
            Controls.Add(Reserve);
            Controls.Add(roomnum_help);
            Controls.Add(roomnum);
            Controls.Add(gmail);
            Controls.Add(title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SveAddsystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "預約";
            Load += SveAddsystem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox gmail;
        private TextBox roomnum;
        private Button roomnum_help;
        private Button Reserve;
        private Button cancle;
    }
}