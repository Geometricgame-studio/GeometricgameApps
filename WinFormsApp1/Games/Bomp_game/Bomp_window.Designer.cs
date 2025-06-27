namespace All_tools_Form_Apps.Games.Bomp_game
{
    partial class Bomp_window
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
            ellipseContorl1 = new Custom_class.EllipseContorl();
            label1 = new Label();
            SuspendLayout();
            // 
            // ellipseContorl1
            // 
            ellipseContorl1.CornerRadius = 999;
            ellipseContorl1.TargetControl = this;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 70);
            label1.Name = "label1";
            label1.Size = new Size(162, 70);
            label1.TabIndex = 0;
            label1.Text = "BUMP!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Bomp_window
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(200, 200);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bomp_window";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "球";
            FormClosing += Bomp_window_FormClosing;
            Load += Bomp_window_Load;
            Click += Bomp_window_Click;
            KeyDown += Bomp_window_KeyDown;
            MouseLeave += Bomp_window_MouseLeave;
            ResumeLayout(false);
        }

        #endregion

        private Custom_class.EllipseContorl ellipseContorl1;
        private Label label1;
    }
}