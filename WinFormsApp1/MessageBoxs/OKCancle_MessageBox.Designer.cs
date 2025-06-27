namespace All_tools_Form_Apps.MessageBoxs
{
    partial class OKCancle_MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OKCancle_MessageBox));
            Message = new Label();
            Error_icon = new PictureBox();
            label1 = new Label();
            ok = new Button();
            Warning_icon = new PictureBox();
            Info_icon = new PictureBox();
            question_icon = new PictureBox();
            NotFound_icon = new PictureBox();
            NoEntry_icon = new PictureBox();
            Link_icon = new PictureBox();
            Cancle = new Button();
            ((System.ComponentModel.ISupportInitialize)Error_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Warning_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Info_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)question_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotFound_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoEntry_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Link_icon).BeginInit();
            SuspendLayout();
            // 
            // Message
            // 
            Message.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Message.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Message.Location = new Point(39, 88);
            Message.Name = "Message";
            Message.Size = new Size(736, 166);
            Message.TabIndex = 0;
            Message.Text = "MessageBox's message";
            Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Error_icon
            // 
            Error_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Error_icon.Image = (Image)resources.GetObject("Error_icon.Image");
            Error_icon.Location = new Point(374, 20);
            Error_icon.Name = "Error_icon";
            Error_icon.Size = new Size(64, 65);
            Error_icon.TabIndex = 1;
            Error_icon.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.LightGray;
            label1.Location = new Point(-2, 308);
            label1.Name = "label1";
            label1.Size = new Size(823, 46);
            label1.TabIndex = 2;
            // 
            // ok
            // 
            ok.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ok.BackColor = Color.White;
            ok.DialogResult = DialogResult.OK;
            ok.FlatStyle = FlatStyle.System;
            ok.Location = new Point(269, 314);
            ok.Name = "ok";
            ok.Size = new Size(138, 34);
            ok.TabIndex = 3;
            ok.Text = "確定(&O)";
            ok.UseVisualStyleBackColor = false;
            ok.Click += ok_Click;
            // 
            // Warning_icon
            // 
            Warning_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Warning_icon.Image = (Image)resources.GetObject("Warning_icon.Image");
            Warning_icon.Location = new Point(374, 20);
            Warning_icon.Name = "Warning_icon";
            Warning_icon.Size = new Size(64, 65);
            Warning_icon.TabIndex = 4;
            Warning_icon.TabStop = false;
            // 
            // Info_icon
            // 
            Info_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Info_icon.Image = (Image)resources.GetObject("Info_icon.Image");
            Info_icon.Location = new Point(374, 20);
            Info_icon.Name = "Info_icon";
            Info_icon.Size = new Size(64, 65);
            Info_icon.TabIndex = 5;
            Info_icon.TabStop = false;
            // 
            // question_icon
            // 
            question_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            question_icon.Image = (Image)resources.GetObject("question_icon.Image");
            question_icon.Location = new Point(374, 20);
            question_icon.Name = "question_icon";
            question_icon.Size = new Size(64, 65);
            question_icon.TabIndex = 6;
            question_icon.TabStop = false;
            // 
            // NotFound_icon
            // 
            NotFound_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NotFound_icon.Image = (Image)resources.GetObject("NotFound_icon.Image");
            NotFound_icon.Location = new Point(374, 20);
            NotFound_icon.Name = "NotFound_icon";
            NotFound_icon.Size = new Size(64, 65);
            NotFound_icon.TabIndex = 7;
            NotFound_icon.TabStop = false;
            // 
            // NoEntry_icon
            // 
            NoEntry_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NoEntry_icon.Image = (Image)resources.GetObject("NoEntry_icon.Image");
            NoEntry_icon.Location = new Point(374, 20);
            NoEntry_icon.Name = "NoEntry_icon";
            NoEntry_icon.Size = new Size(64, 65);
            NoEntry_icon.TabIndex = 8;
            NoEntry_icon.TabStop = false;
            // 
            // Link_icon
            // 
            Link_icon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Link_icon.Image = (Image)resources.GetObject("Link_icon.Image");
            Link_icon.Location = new Point(374, 20);
            Link_icon.Name = "Link_icon";
            Link_icon.Size = new Size(64, 65);
            Link_icon.TabIndex = 9;
            Link_icon.TabStop = false;
            // 
            // Cancle
            // 
            Cancle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cancle.BackColor = Color.White;
            Cancle.DialogResult = DialogResult.Cancel;
            Cancle.FlatStyle = FlatStyle.System;
            Cancle.Location = new Point(413, 314);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(138, 34);
            Cancle.TabIndex = 10;
            Cancle.Text = "取消(&C)";
            Cancle.UseVisualStyleBackColor = false;
            Cancle.Click += Cancle_Click;
            // 
            // OKCancle_MessageBox
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 352);
            Controls.Add(Cancle);
            Controls.Add(Link_icon);
            Controls.Add(NoEntry_icon);
            Controls.Add(NotFound_icon);
            Controls.Add(question_icon);
            Controls.Add(Info_icon);
            Controls.Add(Warning_icon);
            Controls.Add(ok);
            Controls.Add(label1);
            Controls.Add(Error_icon);
            Controls.Add(Message);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OKCancle_MessageBox";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "訊息視窗";
            Load += OK_MessageBox_Load;
            ((System.ComponentModel.ISupportInitialize)Error_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Warning_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Info_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)question_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotFound_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)NoEntry_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Link_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Message;
        private PictureBox Error_icon;
        private Label label1;
        private Button ok;
        private PictureBox Warning_icon;
        private PictureBox Info_icon;
        private PictureBox question_icon;
        private PictureBox NotFound_icon;
        private PictureBox NoEntry_icon;
        private PictureBox Link_icon;
        private Button Cancle;
    }
}