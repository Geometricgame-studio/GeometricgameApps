namespace All_tools_Form_Apps.Advanced_options
{
    partial class CMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMD));
            cmdtxt = new RichTextBox();
            menuStrip1 = new MenuStrip();
            外觀ToolStripMenuItem = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            編輯ToolStripMenuItem = new ToolStripMenuItem();
            copy = new ToolStripMenuItem();
            paste = new ToolStripMenuItem();
            cut = new ToolStripMenuItem();
            cmdtxt_pro_show = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdtxt
            // 
            cmdtxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmdtxt.BackColor = SystemColors.ControlText;
            cmdtxt.BorderStyle = BorderStyle.None;
            cmdtxt.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdtxt.ForeColor = SystemColors.ScrollBar;
            cmdtxt.Location = new Point(-2, 4);
            cmdtxt.Name = "cmdtxt";
            cmdtxt.Size = new Size(1551, 706);
            cmdtxt.TabIndex = 0;
            cmdtxt.Text = "";
            cmdtxt.KeyDown += cmdtxt_KeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Font = new Font("Microsoft JhengHei UI", 9F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 外觀ToolStripMenuItem, 編輯ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1549, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // 外觀ToolStripMenuItem
            // 
            外觀ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exit });
            外觀ToolStripMenuItem.Name = "外觀ToolStripMenuItem";
            外觀ToolStripMenuItem.Size = new Size(62, 28);
            外觀ToolStripMenuItem.Text = "檔案";
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.ShortcutKeys = Keys.Alt | Keys.F4;
            exit.Size = new Size(212, 34);
            exit.Text = "離開";
            exit.Click += exit_Click;
            // 
            // 編輯ToolStripMenuItem
            // 
            編輯ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copy, paste, cut });
            編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            編輯ToolStripMenuItem.Size = new Size(62, 28);
            編輯ToolStripMenuItem.Text = "編輯";
            // 
            // copy
            // 
            copy.Name = "copy";
            copy.ShortcutKeys = Keys.Control | Keys.C;
            copy.Size = new Size(212, 34);
            copy.Text = "複製";
            copy.Click += copy_Click;
            // 
            // paste
            // 
            paste.Name = "paste";
            paste.ShortcutKeys = Keys.Control | Keys.V;
            paste.Size = new Size(212, 34);
            paste.Text = "貼上";
            paste.Click += paste_Click;
            // 
            // cut
            // 
            cut.Name = "cut";
            cut.ShortcutKeys = Keys.Control | Keys.X;
            cut.Size = new Size(212, 34);
            cut.Text = "剪下";
            cut.Click += cut_Click;
            // 
            // cmdtxt_pro_show
            // 
            cmdtxt_pro_show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmdtxt_pro_show.BackColor = SystemColors.ControlText;
            cmdtxt_pro_show.BorderStyle = BorderStyle.None;
            cmdtxt_pro_show.Enabled = false;
            cmdtxt_pro_show.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdtxt_pro_show.ForeColor = SystemColors.ScrollBar;
            cmdtxt_pro_show.Location = new Point(-1, 5);
            cmdtxt_pro_show.Name = "cmdtxt_pro_show";
            cmdtxt_pro_show.Size = new Size(1551, 706);
            cmdtxt_pro_show.TabIndex = 2;
            cmdtxt_pro_show.Text = "";
            cmdtxt_pro_show.Visible = false;
            // 
            // CMD
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1549, 716);
            Controls.Add(menuStrip1);
            Controls.Add(cmdtxt);
            Controls.Add(cmdtxt_pro_show);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "CMD";
            Text = "Command Prompt";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox cmdtxt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 外觀ToolStripMenuItem;
        private ToolStripMenuItem exit;
        private ToolStripMenuItem 編輯ToolStripMenuItem;
        private ToolStripMenuItem copy;
        private ToolStripMenuItem paste;
        private ToolStripMenuItem cut;
        private RichTextBox cmdtxt_pro_show;
    }
}