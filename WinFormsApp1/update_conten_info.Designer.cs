namespace All_tools_Form_Apps
{
    partial class update_conten_info
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
            update_conten = new RichTextBox();
            exit = new Button();
            colorbox1 = new Label();
            see_again = new Button();
            close = new Button();
            ((System.ComponentModel.ISupportInitialize)form_icon).BeginInit();
            SuspendLayout();
            // 
            // title_text
            // 
            title_text.Size = new Size(846, 43);
            // 
            // close_form
            // 
            close_form.FlatAppearance.BorderSize = 0;
            close_form.Location = new Point(809, 0);
            // 
            // min_form
            // 
            min_form.FlatAppearance.BorderSize = 0;
            min_form.Location = new Point(616, 0);
            // 
            // max_form
            // 
            max_form.FlatAppearance.BorderSize = 0;
            max_form.Location = new Point(768, 0);
            // 
            // normal_form
            // 
            normal_form.FlatAppearance.BorderSize = 0;
            // 
            // update_conten
            // 
            update_conten.BackColor = SystemColors.Control;
            update_conten.BorderStyle = BorderStyle.None;
            update_conten.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            update_conten.Location = new Point(13, 43);
            update_conten.Name = "update_conten";
            update_conten.ReadOnly = true;
            update_conten.Size = new Size(845, 477);
            update_conten.TabIndex = 7;
            update_conten.Text = "";
            update_conten.TextChanged += update_conten_TextChanged;
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.System;
            exit.Location = new Point(746, 530);
            exit.Name = "exit";
            exit.Size = new Size(112, 32);
            exit.TabIndex = 8;
            exit.Text = "繼續(&C)";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // colorbox1
            // 
            colorbox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            colorbox1.BackColor = SystemColors.ScrollBar;
            colorbox1.Location = new Point(0, 523);
            colorbox1.Name = "colorbox1";
            colorbox1.Size = new Size(869, 51);
            colorbox1.TabIndex = 9;
            // 
            // see_again
            // 
            see_again.FlatStyle = FlatStyle.System;
            see_again.Location = new Point(607, 530);
            see_again.Name = "see_again";
            see_again.Size = new Size(133, 32);
            see_again.TabIndex = 10;
            see_again.Text = "再看一次(&R)";
            see_again.UseVisualStyleBackColor = true;
            see_again.Click += see_again_Click;
            // 
            // close
            // 
            close.FlatStyle = FlatStyle.System;
            close.Location = new Point(12, 530);
            close.Name = "close";
            close.Size = new Size(108, 32);
            close.TabIndex = 11;
            close.Text = "離開 (&E)";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // update_conten_info
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 574);
            Controls.Add(close);
            Controls.Add(see_again);
            Controls.Add(exit);
            Controls.Add(colorbox1);
            Controls.Add(update_conten);
            MaximizeBox = false;
            Name = "update_conten_info";
            Opacity = 0.99999999999999989D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "更新內容";
            FormClosing += update_conten_info_FormClosing;
            Controls.SetChildIndex(form_icon, 0);
            Controls.SetChildIndex(max_form, 0);
            Controls.SetChildIndex(normal_form, 0);
            Controls.SetChildIndex(min_form, 0);
            Controls.SetChildIndex(update_conten, 0);
            Controls.SetChildIndex(title_text, 0);
            Controls.SetChildIndex(colorbox1, 0);
            Controls.SetChildIndex(exit, 0);
            Controls.SetChildIndex(see_again, 0);
            Controls.SetChildIndex(close, 0);
            Controls.SetChildIndex(close_form, 0);
            ((System.ComponentModel.ISupportInitialize)form_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox update_conten;
        private Button exit;
        private Label colorbox1;
        private Button see_again;
        private Button close;
    }
}