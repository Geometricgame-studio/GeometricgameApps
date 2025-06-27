namespace All_tools_Form_Apps.Additioinal_Forms
{
    partial class Form20_addtional
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
            pictureBox1 = new PictureBox();
            time = new Label();
            txtshowtext = new TextBox();
            btnconfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // time
            // 
            time.Font = new Font("Poppins", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.ForeColor = SystemColors.ButtonFace;
            time.Location = new Point(0, 0);
            time.Name = "time";
            time.Size = new Size(316, 56);
            time.TabIndex = 1;
            time.Text = "Time";
            time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtshowtext
            // 
            txtshowtext.BorderStyle = BorderStyle.None;
            txtshowtext.Location = new Point(0, 0);
            txtshowtext.Multiline = true;
            txtshowtext.Name = "txtshowtext";
            txtshowtext.PlaceholderText = "輸入您要顯示的文字";
            txtshowtext.Size = new Size(387, 97);
            txtshowtext.TabIndex = 2;
            // 
            // btnconfirm
            // 
            btnconfirm.FlatStyle = FlatStyle.System;
            btnconfirm.Location = new Point(275, 103);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(112, 37);
            btnconfirm.TabIndex = 3;
            btnconfirm.Text = "確定 (&O)";
            btnconfirm.UseVisualStyleBackColor = true;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // Form20_addtional
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnconfirm);
            Controls.Add(txtshowtext);
            Controls.Add(time);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form20_addtional";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "螢幕控制器";
            FormClosing += Form20_addtional_FormClosing;
            Load += Form20_addtional_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label time;
        private TextBox txtshowtext;
        private Button btnconfirm;
    }
}