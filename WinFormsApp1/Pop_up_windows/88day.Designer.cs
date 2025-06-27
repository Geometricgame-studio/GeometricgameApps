namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class _88day
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
            Title1 = new Label();
            SuspendLayout();
            // 
            // Title1
            // 
            Title1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title1.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title1.Location = new Point(12, 9);
            Title1.Name = "Title1";
            Title1.Size = new Size(576, 581);
            Title1.TabIndex = 0;
            Title1.Text = "DAD'S TUMMY!";
            Title1.TextAlign = ContentAlignment.MiddleCenter;
            Title1.Click += Title1_Click;
            // 
            // _88day
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(600, 600);
            Controls.Add(Title1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "_88day";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "父親節專用視窗";
            Load += _88day_Load;
            SizeChanged += _88day_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Label Title1;
    }
}