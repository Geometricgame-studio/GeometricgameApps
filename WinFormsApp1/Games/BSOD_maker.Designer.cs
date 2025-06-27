namespace All_tools_Form_Apps.Games
{
    partial class BSOD_maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSOD_maker));
            templete = new ComboBox();
            settinglabel1 = new Label();
            titletext = new TextBox();
            contentext = new TextBox();
            settinglabel2 = new Label();
            qrcodetext = new TextBox();
            settinglebel3 = new Label();
            stopcode_before = new TextBox();
            settinglabel4 = new Label();
            stopcodetext = new TextBox();
            FullScreen = new Button();
            Title = new Label();
            titlefont = new Button();
            fontDialog1 = new FontDialog();
            contenfont = new Button();
            qrcodefont = new Button();
            stopcodefont = new Button();
            conten = new Label();
            pictureBox1 = new PictureBox();
            qrtext = new Label();
            stopcode = new Label();
            settings = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            settings.SuspendLayout();
            SuspendLayout();
            // 
            // templete
            // 
            templete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            templete.DropDownStyle = ComboBoxStyle.DropDownList;
            templete.Font = new Font("Microsoft JhengHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            templete.FormattingEnabled = true;
            templete.Items.AddRange(new object[] { "Windows 8 ~ 11", "Windows XP ~ 7", "Windows 95 ~ 98" });
            templete.Location = new Point(129, 26);
            templete.Name = "templete";
            templete.Size = new Size(280, 28);
            templete.TabIndex = 0;
            templete.SelectedIndexChanged += templete_SelectedIndexChanged;
            // 
            // settinglabel1
            // 
            settinglabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settinglabel1.AutoSize = true;
            settinglabel1.BackColor = SystemColors.ControlLight;
            settinglabel1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            settinglabel1.ForeColor = SystemColors.ControlText;
            settinglabel1.Location = new Point(14, 26);
            settinglabel1.Name = "settinglabel1";
            settinglabel1.Size = new Size(109, 90);
            settinglabel1.TabIndex = 1;
            settinglabel1.Text = "選擇範本\r\n標題文字\r\n內容文字";
            // 
            // titletext
            // 
            titletext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            titletext.Location = new Point(129, 57);
            titletext.Name = "titletext";
            titletext.PlaceholderText = "例如 :(";
            titletext.Size = new Size(236, 30);
            titletext.TabIndex = 3;
            // 
            // contentext
            // 
            contentext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            contentext.Location = new Point(129, 91);
            contentext.Multiline = true;
            contentext.Name = "contentext";
            contentext.PlaceholderText = "例如 您的電腦發生問題";
            contentext.Size = new Size(280, 186);
            contentext.TabIndex = 4;
            // 
            // settinglabel2
            // 
            settinglabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settinglabel2.AutoSize = true;
            settinglabel2.BackColor = SystemColors.ControlLight;
            settinglabel2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            settinglabel2.ForeColor = SystemColors.ControlText;
            settinglabel2.Location = new Point(14, 317);
            settinglabel2.Name = "settinglabel2";
            settinglabel2.Size = new Size(109, 30);
            settinglabel2.TabIndex = 5;
            settinglabel2.Text = "解決辦法";
            // 
            // qrcodetext
            // 
            qrcodetext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qrcodetext.Location = new Point(129, 317);
            qrcodetext.Multiline = true;
            qrcodetext.Name = "qrcodetext";
            qrcodetext.PlaceholderText = "例如 更多資訊請前往 https://freeegeometricgames.com";
            qrcodetext.Size = new Size(280, 137);
            qrcodetext.TabIndex = 6;
            // 
            // settinglebel3
            // 
            settinglebel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settinglebel3.AutoSize = true;
            settinglebel3.BackColor = SystemColors.ControlLight;
            settinglebel3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            settinglebel3.ForeColor = SystemColors.ControlText;
            settinglebel3.Location = new Point(14, 491);
            settinglebel3.Name = "settinglebel3";
            settinglebel3.Size = new Size(157, 30);
            settinglebel3.TabIndex = 7;
            settinglebel3.Text = "停止代碼前綴";
            // 
            // stopcode_before
            // 
            stopcode_before.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stopcode_before.Location = new Point(177, 491);
            stopcode_before.Multiline = true;
            stopcode_before.Name = "stopcode_before";
            stopcode_before.PlaceholderText = "例如 如果您找到了支援人員，請告訴他以下資訊:";
            stopcode_before.Size = new Size(232, 132);
            stopcode_before.TabIndex = 8;
            // 
            // settinglabel4
            // 
            settinglabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settinglabel4.AutoSize = true;
            settinglabel4.BackColor = SystemColors.ControlLight;
            settinglabel4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            settinglabel4.ForeColor = SystemColors.ControlText;
            settinglabel4.Location = new Point(14, 625);
            settinglabel4.Name = "settinglabel4";
            settinglabel4.Size = new Size(109, 30);
            settinglabel4.TabIndex = 9;
            settinglabel4.Text = "停止代碼";
            // 
            // stopcodetext
            // 
            stopcodetext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stopcodetext.Location = new Point(129, 628);
            stopcodetext.Name = "stopcodetext";
            stopcodetext.PlaceholderText = "例如 WINDOWS_FINAL_ERROR";
            stopcodetext.Size = new Size(236, 30);
            stopcodetext.TabIndex = 10;
            // 
            // FullScreen
            // 
            FullScreen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullScreen.BackColor = SystemColors.ControlLightLight;
            FullScreen.FlatStyle = FlatStyle.Flat;
            FullScreen.ForeColor = SystemColors.ControlText;
            FullScreen.Location = new Point(300, 664);
            FullScreen.Name = "FullScreen";
            FullScreen.Size = new Size(109, 45);
            FullScreen.TabIndex = 11;
            FullScreen.Text = "設定完成";
            FullScreen.UseVisualStyleBackColor = false;
            FullScreen.Click += FullScreen_Click;
            // 
            // Title
            // 
            Title.Font = new Font("Microsoft JhengHei UI", 100F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Title.Location = new Point(31, 19);
            Title.Name = "Title";
            Title.Size = new Size(282, 284);
            Title.TabIndex = 12;
            Title.Text = ":(";
            // 
            // titlefont
            // 
            titlefont.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            titlefont.BackColor = SystemColors.ControlLightLight;
            titlefont.FlatStyle = FlatStyle.Flat;
            titlefont.ForeColor = SystemColors.ControlText;
            titlefont.Location = new Point(371, 57);
            titlefont.Name = "titlefont";
            titlefont.Size = new Size(38, 28);
            titlefont.TabIndex = 13;
            titlefont.Text = "...";
            titlefont.UseVisualStyleBackColor = false;
            titlefont.Click += titlefont_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.HelpRequest += fontDialog1_HelpRequest;
            // 
            // contenfont
            // 
            contenfont.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            contenfont.BackColor = SystemColors.ControlLightLight;
            contenfont.FlatStyle = FlatStyle.Flat;
            contenfont.ForeColor = SystemColors.ControlText;
            contenfont.Location = new Point(129, 283);
            contenfont.Name = "contenfont";
            contenfont.Size = new Size(280, 28);
            contenfont.TabIndex = 14;
            contenfont.Text = "...";
            contenfont.UseVisualStyleBackColor = false;
            contenfont.Click += contenfont_Click;
            // 
            // qrcodefont
            // 
            qrcodefont.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qrcodefont.BackColor = SystemColors.ControlLightLight;
            qrcodefont.FlatStyle = FlatStyle.Flat;
            qrcodefont.ForeColor = SystemColors.ControlText;
            qrcodefont.Location = new Point(129, 460);
            qrcodefont.Name = "qrcodefont";
            qrcodefont.Size = new Size(280, 28);
            qrcodefont.TabIndex = 15;
            qrcodefont.Text = "...";
            qrcodefont.UseVisualStyleBackColor = false;
            qrcodefont.Click += qrcodefont_Click;
            // 
            // stopcodefont
            // 
            stopcodefont.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stopcodefont.BackColor = SystemColors.ControlLightLight;
            stopcodefont.FlatStyle = FlatStyle.Flat;
            stopcodefont.ForeColor = SystemColors.ControlText;
            stopcodefont.Location = new Point(371, 630);
            stopcodefont.Name = "stopcodefont";
            stopcodefont.Size = new Size(38, 28);
            stopcodefont.TabIndex = 16;
            stopcodefont.Text = "...";
            stopcodefont.UseVisualStyleBackColor = false;
            // 
            // conten
            // 
            conten.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            conten.Location = new Point(93, 292);
            conten.Name = "conten";
            conten.Size = new Size(791, 209);
            conten.TabIndex = 17;
            conten.Text = "您的裝置發生問題，我們正在收集一些錯誤資訊，然後我們將為您重新啟動。";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 504);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // qrtext
            // 
            qrtext.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            qrtext.Location = new Point(289, 504);
            qrtext.Name = "qrtext";
            qrtext.Size = new Size(824, 97);
            qrtext.TabIndex = 19;
            qrtext.Text = "*詳細說明";
            // 
            // stopcode
            // 
            stopcode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            stopcode.Location = new Point(289, 601);
            stopcode.Name = "stopcode";
            stopcode.Size = new Size(824, 97);
            stopcode.TabIndex = 20;
            stopcode.Text = "*停止代碼";
            // 
            // settings
            // 
            settings.BackColor = SystemColors.ControlLight;
            settings.Controls.Add(settinglabel1);
            settings.Controls.Add(templete);
            settings.Controls.Add(titletext);
            settings.Controls.Add(contentext);
            settings.Controls.Add(settinglabel2);
            settings.Controls.Add(stopcodefont);
            settings.Controls.Add(qrcodetext);
            settings.Controls.Add(qrcodefont);
            settings.Controls.Add(settinglebel3);
            settings.Controls.Add(contenfont);
            settings.Controls.Add(stopcode_before);
            settings.Controls.Add(titlefont);
            settings.Controls.Add(settinglabel4);
            settings.Controls.Add(stopcodetext);
            settings.Controls.Add(FullScreen);
            settings.Location = new Point(1119, 12);
            settings.Name = "settings";
            settings.Size = new Size(424, 731);
            settings.TabIndex = 21;
            settings.TabStop = false;
            // 
            // BSOD_maker
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1538, 836);
            Controls.Add(settings);
            Controls.Add(stopcode);
            Controls.Add(qrtext);
            Controls.Add(pictureBox1);
            Controls.Add(conten);
            Controls.Add(Title);
            ForeColor = SystemColors.ControlLightLight;
            Name = "BSOD_maker";
            Text = "BSOD 訂製器";
            Load += BSOD_maker_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            settings.ResumeLayout(false);
            settings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox templete;
        private Label settinglabel1;
        private TextBox titletext;
        private TextBox contentext;
        private Label settinglabel2;
        private TextBox qrcodetext;
        private Label settinglebel3;
        private TextBox stopcode_before;
        private Label settinglabel4;
        private TextBox stopcodetext;
        private Button FullScreen;
        private Label Title;
        private Button titlefont;
        private FontDialog fontDialog1;
        private Button contenfont;
        private Button qrcodefont;
        private Button stopcodefont;
        private Label conten;
        private PictureBox pictureBox1;
        private Label qrtext;
        private Label stopcode;
        private GroupBox settings;
    }
}