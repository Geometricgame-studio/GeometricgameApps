namespace All_tools_Form_Apps
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            button1 = new Button();
            label1 = new Label();
            vertion = new Label();
            complete = new Label();
            label2 = new Label();
            progressBar1 = new Custom_class.Custom_ProgessBar();
            ellipseContorl1 = new Custom_class.EllipseContorl();
            process1 = new System.Diagnostics.Process();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(13, 256);
            button1.Name = "button1";
            button1.Size = new Size(776, 45);
            button1.TabIndex = 0;
            button1.Text = "❌ 關閉啟動器";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new Font("Poppins", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(768, 70);
            label1.TabIndex = 2;
            label1.Text = "Loading Geometricgames App......";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.Click += Form_is_click;
            // 
            // vertion
            // 
            vertion.Font = new Font("Microsoft JhengHei", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vertion.ForeColor = SystemColors.ControlLightLight;
            vertion.Location = new Point(13, 304);
            vertion.Name = "vertion";
            vertion.Size = new Size(776, 44);
            vertion.TabIndex = 3;
            vertion.Text = "Geometricgames version";
            vertion.TextAlign = ContentAlignment.MiddleRight;
            vertion.UseCompatibleTextRendering = true;
            vertion.Click += Form_is_click;
            // 
            // complete
            // 
            complete.AutoSize = true;
            complete.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            complete.ForeColor = SystemColors.ControlLightLight;
            complete.Location = new Point(359, 188);
            complete.Name = "complete";
            complete.Size = new Size(94, 56);
            complete.TabIndex = 4;
            complete.Text = "50%";
            complete.Click += Form_is_click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(53, 112);
            label2.Name = "label2";
            label2.Size = new Size(694, 70);
            label2.TabIndex = 5;
            label2.Text = "Loading Geometricgames App......";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += Form_is_click;
            // 
            // progressBar1
            // 
            progressBar1.ChannelColor = Color.Black;
            progressBar1.ChannelHeight = 6;
            progressBar1.ForeBackColor = Color.RoyalBlue;
            progressBar1.ForeColor = Color.White;
            progressBar1.Location = new Point(6, 351);
            progressBar1.Name = "progressBar1";
            progressBar1.ShowValue = Custom_class.TextPosition.None;
            progressBar1.Size = new Size(792, 21);
            progressBar1.SliderColor = Color.DodgerBlue;
            progressBar1.SliderHeight = 6;
            progressBar1.TabIndex = 6;
            progressBar1.Click += Form_is_click;
            // 
            // ellipseContorl1
            // 
            ellipseContorl1.CornerRadius = 50;
            ellipseContorl1.TargetControl = this;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 373);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(complete);
            Controls.Add(vertion);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadingForm";
            Text = "GeometricgameApps";
            Load += LoadingForm_Load;
            Click += Form_is_click;
            MouseClick += LoadingForm_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label vertion;
        private Label complete;
        private Label label2;
        private Custom_class.Custom_ProgessBar progressBar1;
        private Custom_class.EllipseContorl ellipseContorl1;
        private System.Diagnostics.Process process1;
    }
}