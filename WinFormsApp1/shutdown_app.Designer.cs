namespace All_tools_Form_Apps
{
    partial class shutdown_app
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
            label1 = new Label();
            progressBar1 = new Custom_class.Custom_ProgessBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1287, 460);
            label1.TabIndex = 0;
            label1.Text = "SHUTDOWN_MODE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.ChannelColor = Color.LightSteelBlue;
            progressBar1.ChannelHeight = 5;
            progressBar1.ForeBackColor = Color.RoyalBlue;
            progressBar1.ForeColor = Color.White;
            progressBar1.Location = new Point(0, 418);
            progressBar1.Maximum = 1000;
            progressBar1.Name = "progressBar1";
            progressBar1.ShowValue = Custom_class.TextPosition.None;
            progressBar1.Size = new Size(800, 34);
            progressBar1.SliderColor = Color.RoyalBlue;
            progressBar1.SliderHeight = 6;
            progressBar1.TabIndex = 1;
            // 
            // shutdown_app
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1287, 638);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "shutdown_app";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "shutdown_app";
            Load += shutdown_app_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Custom_class.Custom_ProgessBar progressBar1;
    }
}