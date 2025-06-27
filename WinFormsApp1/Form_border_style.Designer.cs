namespace All_tools_Form_Apps
{
    partial class Form_border_style
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_border_style));
            ellipseContorl1 = new Custom_class.EllipseContorl();
            title_text = new Label();
            form_icon = new PictureBox();
            close_form = new Button();
            min_form = new Button();
            max_form = new Button();
            normal_form = new Button();
            ((System.ComponentModel.ISupportInitialize)form_icon).BeginInit();
            SuspendLayout();
            // 
            // ellipseContorl1
            // 
            ellipseContorl1.CornerRadius = 20;
            ellipseContorl1.TargetControl = this;
            // 
            // title_text
            // 
            title_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title_text.BackColor = Color.FromArgb(247, 204, 10);
            title_text.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            title_text.Location = new Point(13, 0);
            title_text.Name = "title_text";
            title_text.Size = new Size(900, 43);
            title_text.TabIndex = 1;
            title_text.Text = "視窗標題";
            title_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_icon
            // 
            form_icon.BackColor = Color.FromArgb(247, 204, 10);
            form_icon.Location = new Point(0, 0);
            form_icon.Name = "form_icon";
            form_icon.Size = new Size(60, 43);
            form_icon.SizeMode = PictureBoxSizeMode.Zoom;
            form_icon.TabIndex = 6;
            form_icon.TabStop = false;
            // 
            // close_form
            // 
            close_form.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_form.BackColor = Color.FromArgb(247, 174, 10);
            close_form.BackgroundImage = (Image)resources.GetObject("close_form.BackgroundImage");
            close_form.BackgroundImageLayout = ImageLayout.Zoom;
            close_form.Cursor = Cursors.Hand;
            close_form.FlatAppearance.BorderSize = 0;
            close_form.FlatStyle = FlatStyle.Flat;
            close_form.Location = new Point(865, 0);
            close_form.Name = "close_form";
            close_form.Size = new Size(60, 43);
            close_form.TabIndex = 50;
            close_form.UseVisualStyleBackColor = false;
            close_form.Click += close_form_Click;
            // 
            // min_form
            // 
            min_form.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min_form.BackColor = Color.FromArgb(247, 174, 10);
            min_form.BackgroundImage = (Image)resources.GetObject("min_form.BackgroundImage");
            min_form.BackgroundImageLayout = ImageLayout.Zoom;
            min_form.Cursor = Cursors.Hand;
            min_form.FlatAppearance.BorderSize = 0;
            min_form.FlatStyle = FlatStyle.Flat;
            min_form.Location = new Point(805, 0);
            min_form.Name = "min_form";
            min_form.Size = new Size(60, 43);
            min_form.TabIndex = 49;
            min_form.UseVisualStyleBackColor = false;
            min_form.Click += min_form_Click;
            // 
            // max_form
            // 
            max_form.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            max_form.BackColor = Color.FromArgb(247, 174, 10);
            max_form.BackgroundImage = (Image)resources.GetObject("max_form.BackgroundImage");
            max_form.BackgroundImageLayout = ImageLayout.Zoom;
            max_form.Cursor = Cursors.Hand;
            max_form.FlatAppearance.BorderSize = 0;
            max_form.FlatStyle = FlatStyle.Flat;
            max_form.Location = new Point(750, 0);
            max_form.Name = "max_form";
            max_form.Size = new Size(55, 43);
            max_form.TabIndex = 48;
            max_form.UseVisualStyleBackColor = false;
            max_form.Click += max_form_Click;
            // 
            // normal_form
            // 
            normal_form.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            normal_form.BackColor = Color.FromArgb(247, 174, 10);
            normal_form.BackgroundImage = (Image)resources.GetObject("normal_form.BackgroundImage");
            normal_form.BackgroundImageLayout = ImageLayout.Zoom;
            normal_form.Cursor = Cursors.Hand;
            normal_form.FlatAppearance.BorderSize = 0;
            normal_form.FlatStyle = FlatStyle.Flat;
            normal_form.Location = new Point(695, 0);
            normal_form.Name = "normal_form";
            normal_form.Size = new Size(55, 43);
            normal_form.TabIndex = 51;
            normal_form.UseVisualStyleBackColor = false;
            normal_form.Click += normal_form_Click;
            // 
            // Form_border_style
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(924, 523);
            Controls.Add(normal_form);
            Controls.Add(close_form);
            Controls.Add(min_form);
            Controls.Add(max_form);
            Controls.Add(form_icon);
            Controls.Add(title_text);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_border_style";
            Text = "Form_border_style";
            FormClosing += Form_border_style_FormClosing;
            Load += Form_border_style_Load;
            ((System.ComponentModel.ISupportInitialize)form_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Custom_class.EllipseContorl ellipseContorl1;
        public Label title_text;
        public PictureBox form_icon;
        public Button close_form;
        public Button min_form;
        public Button max_form;
        public Button normal_form;
    }
}