namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            msgtitle = new TextBox();
            button1 = new Button();
            text1 = new Label();
            msgtext = new TextBox();
            text2 = new Label();
            button2 = new Button();
            label1 = new Label();
            window_title = new Label();
            nexttool = new Button();
            save_conten = new Button();
            msgboxicon = new ComboBox();
            SuspendLayout();
            // 
            // msgtitle
            // 
            msgtitle.BorderStyle = BorderStyle.None;
            msgtitle.Cursor = Cursors.IBeam;
            msgtitle.Location = new Point(10, 64);
            msgtitle.MaxLength = 100;
            msgtitle.Multiline = true;
            msgtitle.Name = "msgtitle";
            msgtitle.PlaceholderText = "輸入視窗標題";
            msgtitle.Size = new Size(230, 100);
            msgtitle.TabIndex = 0;
            msgtitle.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(12, 432);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "產生";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(12, 38);
            text1.Name = "text1";
            text1.Size = new Size(118, 23);
            text1.TabIndex = 3;
            text1.Text = "輸入視窗標題";
            // 
            // msgtext
            // 
            msgtext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            msgtext.Cursor = Cursors.IBeam;
            msgtext.Location = new Point(10, 210);
            msgtext.Multiline = true;
            msgtext.Name = "msgtext";
            msgtext.PlaceholderText = "輸入內容文字";
            msgtext.Size = new Size(230, 100);
            msgtext.TabIndex = 4;
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new Point(12, 184);
            text2.Name = "text2";
            text2.Size = new Size(118, 23);
            text2.TabIndex = 5;
            text2.Text = "輸入內容文字";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(123, 432);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "重置";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 334);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 8;
            label1.Text = "選擇圖標";
            // 
            // window_title
            // 
            window_title.AutoSize = true;
            window_title.BackColor = SystemColors.ControlText;
            window_title.ForeColor = SystemColors.Control;
            window_title.Location = new Point(18, 9);
            window_title.Name = "window_title";
            window_title.Size = new Size(219, 23);
            window_title.TabIndex = 10;
            window_title.Text = "Windows 彈出視窗產生器\r\n";
            window_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // nexttool
            // 
            nexttool.Cursor = Cursors.Hand;
            nexttool.FlatStyle = FlatStyle.System;
            nexttool.Location = new Point(10, 467);
            nexttool.Name = "nexttool";
            nexttool.Size = new Size(228, 34);
            nexttool.TabIndex = 11;
            nexttool.Text = "到下一個工具視窗";
            nexttool.UseVisualStyleBackColor = true;
            nexttool.Click += nexttool_Click;
            // 
            // save_conten
            // 
            save_conten.Cursor = Cursors.Hand;
            save_conten.FlatStyle = FlatStyle.System;
            save_conten.Location = new Point(10, 397);
            save_conten.Name = "save_conten";
            save_conten.Size = new Size(225, 34);
            save_conten.TabIndex = 12;
            save_conten.Text = "儲存";
            save_conten.UseVisualStyleBackColor = true;
            save_conten.Click += save_conten_Click;
            // 
            // msgboxicon
            // 
            msgboxicon.Cursor = Cursors.Hand;
            msgboxicon.DropDownStyle = ComboBoxStyle.DropDownList;
            msgboxicon.FlatStyle = FlatStyle.System;
            msgboxicon.FormattingEnabled = true;
            msgboxicon.Items.AddRange(new object[] { "無", "錯誤圖標", "警示圖標", "問號圖標", "i 圖標" });
            msgboxicon.Location = new Point(8, 360);
            msgboxicon.Name = "msgboxicon";
            msgboxicon.Size = new Size(230, 31);
            msgboxicon.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(252, 513);
            Controls.Add(save_conten);
            Controls.Add(nexttool);
            Controls.Add(window_title);
            Controls.Add(msgboxicon);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(text2);
            Controls.Add(msgtext);
            Controls.Add(text1);
            Controls.Add(button1);
            Controls.Add(msgtitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Windows 彈跳視窗產生器";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox msgtitle;
        private Button button1;
        private Label text1;
        private TextBox msgtext;
        private Label text2;
        private Button button2;
        private Label label1;
        private Label window_title;
        private Button nexttool;
        private Button save_conten;
        private ComboBox msgboxicon;
    }
}
