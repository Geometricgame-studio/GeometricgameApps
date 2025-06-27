using All_tools_Form_Apps.Custom_class;

namespace All_tools_Form_Apps.MessageBoxs
{
    partial class Notify_normal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notify_normal));
            Head = new Label();
            info = new PictureBox();
            Conten = new Label();
            Exit = new PictureBox();
            ellipseContorl2 = new EllipseContorl();
            error = new PictureBox();
            warning = new PictureBox();
            complete = new PictureBox();
            timer = new Label();
            ((System.ComponentModel.ISupportInitialize)info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)complete).BeginInit();
            SuspendLayout();
            // 
            // Head
            // 
            Head.Anchor = AnchorStyles.Left;
            Head.AutoSize = true;
            Head.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Head.ForeColor = SystemColors.ControlText;
            Head.Location = new Point(98, 32);
            Head.Name = "Head";
            Head.Size = new Size(116, 56);
            Head.TabIndex = 0;
            Head.Text = "Title";
            // 
            // info
            // 
            info.Anchor = AnchorStyles.Left;
            info.Image = (Image)resources.GetObject("info.Image");
            info.Location = new Point(12, 42);
            info.Name = "info";
            info.Size = new Size(63, 66);
            info.SizeMode = PictureBoxSizeMode.Zoom;
            info.TabIndex = 1;
            info.TabStop = false;
            // 
            // Conten
            // 
            Conten.Anchor = AnchorStyles.Left;
            Conten.AutoSize = true;
            Conten.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Conten.Location = new Point(98, 88);
            Conten.Name = "Conten";
            Conten.Size = new Size(127, 41);
            Conten.TabIndex = 2;
            Conten.Text = "Conten";
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Right;
            Exit.Enabled = false;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(963, 32);
            Exit.Name = "Exit";
            Exit.Size = new Size(77, 57);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 3;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // ellipseContorl2
            // 
            ellipseContorl2.CornerRadius = 50;
            ellipseContorl2.TargetControl = this;
            // 
            // error
            // 
            error.Anchor = AnchorStyles.Left;
            error.Image = (Image)resources.GetObject("error.Image");
            error.Location = new Point(12, 42);
            error.Name = "error";
            error.Size = new Size(63, 66);
            error.SizeMode = PictureBoxSizeMode.Zoom;
            error.TabIndex = 5;
            error.TabStop = false;
            // 
            // warning
            // 
            warning.Anchor = AnchorStyles.Left;
            warning.Image = (Image)resources.GetObject("warning.Image");
            warning.Location = new Point(12, 42);
            warning.Name = "warning";
            warning.Size = new Size(63, 66);
            warning.SizeMode = PictureBoxSizeMode.Zoom;
            warning.TabIndex = 6;
            warning.TabStop = false;
            // 
            // complete
            // 
            complete.Anchor = AnchorStyles.Left;
            complete.Image = (Image)resources.GetObject("complete.Image");
            complete.Location = new Point(12, 42);
            complete.Name = "complete";
            complete.Size = new Size(63, 66);
            complete.SizeMode = PictureBoxSizeMode.Zoom;
            complete.TabIndex = 7;
            complete.TabStop = false;
            // 
            // timer
            // 
            timer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timer.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            timer.Location = new Point(963, 93);
            timer.Name = "timer";
            timer.Size = new Size(77, 36);
            timer.TabIndex = 8;
            timer.Text = "0.00";
            // 
            // Notify_normal
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1052, 174);
            Controls.Add(timer);
            Controls.Add(complete);
            Controls.Add(warning);
            Controls.Add(error);
            Controls.Add(Exit);
            Controls.Add(Conten);
            Controls.Add(info);
            Controls.Add(Head);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notify_normal";
            Text = "通知";
            Load += Notify_normal_Load;
            ((System.ComponentModel.ISupportInitialize)info).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ((System.ComponentModel.ISupportInitialize)warning).EndInit();
            ((System.ComponentModel.ISupportInitialize)complete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Head;
        private PictureBox info;
        private Label Conten;
        private PictureBox Exit;
        private EllipseContorl ellipseContorl1;
        private EllipseContorl ellipseContorl2;
        private PictureBox warning;
        private PictureBox error;
        private PictureBox complete;
        private Label timer;
    }
}