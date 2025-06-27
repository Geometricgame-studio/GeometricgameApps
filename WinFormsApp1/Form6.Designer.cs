using System.Security.Cryptography.X509Certificates;

namespace All_tools_Form_Apps
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            NewFile = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            SaveFile = new ToolStripMenuItem();
            Auto_save = new ToolStripMenuItem();
            SaveNewFile = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            Print = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            ExitForm = new ToolStripMenuItem();
            編輯ToolStripMenuItem = new ToolStripMenuItem();
            Undo = new ToolStripMenuItem();
            Redo = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            Cut = new ToolStripMenuItem();
            Copy = new ToolStripMenuItem();
            Paste = new ToolStripMenuItem();
            Select_all = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            Delete = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            Find = new ToolStripMenuItem();
            格式ToolStripMenuItem = new ToolStripMenuItem();
            Word_warp = new ToolStripMenuItem();
            Font = new ToolStripMenuItem();
            HighLight_text = new ToolStripMenuItem();
            UnHighlight_text = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            FontColor = new ToolStripMenuItem();
            Reset = new ToolStripMenuItem();
            幫助ToolStripMenuItem = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            Usage = new ToolStripMenuItem();
            edit_area = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            fontDialog1 = new FontDialog();
            Saved_text = new RichTextBox();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 編輯ToolStripMenuItem, 格式ToolStripMenuItem, 設定ToolStripMenuItem, 幫助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1171, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFile, OpenFile, SaveFile, Auto_save, SaveNewFile, toolStripMenuItem1, Print, toolStripMenuItem4, ExitForm });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.ShortcutKeyDisplayString = "";
            檔案ToolStripMenuItem.Size = new Size(62, 27);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // NewFile
            // 
            NewFile.Image = (Image)resources.GetObject("NewFile.Image");
            NewFile.Name = "NewFile";
            NewFile.ShortcutKeys = Keys.Control | Keys.N;
            NewFile.Size = new Size(298, 34);
            NewFile.Text = "新檔案";
            NewFile.Click += NewFile_Click;
            // 
            // OpenFile
            // 
            OpenFile.Image = (Image)resources.GetObject("OpenFile.Image");
            OpenFile.Name = "OpenFile";
            OpenFile.ShortcutKeys = Keys.Control | Keys.O;
            OpenFile.Size = new Size(298, 34);
            OpenFile.Text = "開啟";
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.Image = (Image)resources.GetObject("SaveFile.Image");
            SaveFile.Name = "SaveFile";
            SaveFile.ShortcutKeys = Keys.Control | Keys.S;
            SaveFile.Size = new Size(298, 34);
            SaveFile.Text = "存檔";
            SaveFile.Click += SaveFile_Click;
            // 
            // Auto_save
            // 
            Auto_save.Image = (Image)resources.GetObject("Auto_save.Image");
            Auto_save.Name = "Auto_save";
            Auto_save.Size = new Size(298, 34);
            Auto_save.Text = "自動儲存";
            Auto_save.Click += Auto_save_Click;
            // 
            // SaveNewFile
            // 
            SaveNewFile.Image = (Image)resources.GetObject("SaveNewFile.Image");
            SaveNewFile.Name = "SaveNewFile";
            SaveNewFile.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            SaveNewFile.Size = new Size(298, 34);
            SaveNewFile.Text = "另存新檔";
            SaveNewFile.Click += SaveNewFile_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(295, 6);
            // 
            // Print
            // 
            Print.Image = (Image)resources.GetObject("Print.Image");
            Print.Name = "Print";
            Print.ShortcutKeys = Keys.Control | Keys.P;
            Print.Size = new Size(298, 34);
            Print.Text = "列印";
            Print.Click += Print_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(295, 6);
            // 
            // ExitForm
            // 
            ExitForm.Image = (Image)resources.GetObject("ExitForm.Image");
            ExitForm.Name = "ExitForm";
            ExitForm.ShortcutKeys = Keys.Alt | Keys.F4;
            ExitForm.Size = new Size(298, 34);
            ExitForm.Text = "結束";
            ExitForm.Click += ExitForm_Click;
            // 
            // 編輯ToolStripMenuItem
            // 
            編輯ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Undo, Redo, toolStripMenuItem2, Cut, Copy, Paste, Select_all, toolStripMenuItem3, Delete, toolStripMenuItem5, Find });
            編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            編輯ToolStripMenuItem.Size = new Size(62, 27);
            編輯ToolStripMenuItem.Text = "編輯";
            // 
            // Undo
            // 
            Undo.Image = (Image)resources.GetObject("Undo.Image");
            Undo.Name = "Undo";
            Undo.ShortcutKeys = Keys.Control | Keys.Z;
            Undo.Size = new Size(248, 34);
            Undo.Text = "退回";
            Undo.Click += Undo_Click;
            // 
            // Redo
            // 
            Redo.Image = (Image)resources.GetObject("Redo.Image");
            Redo.Name = "Redo";
            Redo.ShortcutKeys = Keys.Control | Keys.Y;
            Redo.Size = new Size(248, 34);
            Redo.Text = "重做";
            Redo.Click += Redo_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(245, 6);
            // 
            // Cut
            // 
            Cut.Image = (Image)resources.GetObject("Cut.Image");
            Cut.Name = "Cut";
            Cut.ShortcutKeys = Keys.Control | Keys.X;
            Cut.Size = new Size(248, 34);
            Cut.Text = "剪下";
            Cut.Click += Cut_Click;
            // 
            // Copy
            // 
            Copy.Image = (Image)resources.GetObject("Copy.Image");
            Copy.Name = "Copy";
            Copy.ShortcutKeys = Keys.Control | Keys.C;
            Copy.Size = new Size(248, 34);
            Copy.Text = "複製";
            Copy.Click += Copy_Click;
            // 
            // Paste
            // 
            Paste.Image = (Image)resources.GetObject("Paste.Image");
            Paste.Name = "Paste";
            Paste.ShortcutKeys = Keys.Control | Keys.V;
            Paste.Size = new Size(248, 34);
            Paste.Text = "貼上";
            Paste.Click += Paste_Click;
            // 
            // Select_all
            // 
            Select_all.Image = (Image)resources.GetObject("Select_all.Image");
            Select_all.Name = "Select_all";
            Select_all.ShortcutKeys = Keys.Control | Keys.A;
            Select_all.Size = new Size(248, 34);
            Select_all.Text = "選取全部";
            Select_all.Click += Select_all_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(245, 6);
            // 
            // Delete
            // 
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ShortcutKeys = Keys.Delete;
            Delete.Size = new Size(248, 34);
            Delete.Text = "刪除";
            Delete.Click += Delete_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(245, 6);
            // 
            // Find
            // 
            Find.Image = (Image)resources.GetObject("Find.Image");
            Find.Name = "Find";
            Find.ShortcutKeys = Keys.Control | Keys.F;
            Find.Size = new Size(248, 34);
            Find.Text = "尋找";
            Find.Click += Find_Click;
            // 
            // 格式ToolStripMenuItem
            // 
            格式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Word_warp, Font, HighLight_text, UnHighlight_text });
            格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            格式ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            格式ToolStripMenuItem.Size = new Size(62, 27);
            格式ToolStripMenuItem.Text = "格式";
            // 
            // Word_warp
            // 
            Word_warp.Image = (Image)resources.GetObject("Word_warp.Image");
            Word_warp.Name = "Word_warp";
            Word_warp.Size = new Size(356, 34);
            Word_warp.Text = "自動換行";
            Word_warp.Click += Word_warp_Click;
            // 
            // Font
            // 
            Font.Image = (Image)resources.GetObject("Font.Image");
            Font.Name = "Font";
            Font.Size = new Size(356, 34);
            Font.Text = "字形";
            Font.Click += Font_Click;
            // 
            // HighLight_text
            // 
            HighLight_text.Image = (Image)resources.GetObject("HighLight_text.Image");
            HighLight_text.Name = "HighLight_text";
            HighLight_text.ShortcutKeys = Keys.Control | Keys.H;
            HighLight_text.Size = new Size(356, 34);
            HighLight_text.Text = "螢光筆標記";
            HighLight_text.Click += HighLight_text_Click;
            // 
            // UnHighlight_text
            // 
            UnHighlight_text.Name = "UnHighlight_text";
            UnHighlight_text.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            UnHighlight_text.Size = new Size(356, 34);
            UnHighlight_text.Text = "取消螢光筆標記";
            UnHighlight_text.Click += UnHighlight_text_Click;
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontColor, Reset });
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(62, 27);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // FontColor
            // 
            FontColor.Image = (Image)resources.GetObject("FontColor.Image");
            FontColor.Name = "FontColor";
            FontColor.Size = new Size(182, 34);
            FontColor.Text = "字體顏色";
            FontColor.Click += FontColor_Click;
            // 
            // Reset
            // 
            Reset.Image = (Image)resources.GetObject("Reset.Image");
            Reset.Name = "Reset";
            Reset.Size = new Size(182, 34);
            Reset.Text = "重置";
            Reset.Click += Reset_Click;
            // 
            // 幫助ToolStripMenuItem
            // 
            幫助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { About, Usage });
            幫助ToolStripMenuItem.Name = "幫助ToolStripMenuItem";
            幫助ToolStripMenuItem.Size = new Size(62, 27);
            幫助ToolStripMenuItem.Text = "幫助";
            // 
            // About
            // 
            About.Image = (Image)resources.GetObject("About.Image");
            About.Name = "About";
            About.Size = new Size(211, 34);
            About.Text = "關於";
            About.Click += About_Click;
            // 
            // Usage
            // 
            Usage.Image = (Image)resources.GetObject("Usage.Image");
            Usage.Name = "Usage";
            Usage.ShortcutKeys = Keys.F1;
            Usage.Size = new Size(211, 34);
            Usage.Text = "使用說明";
            Usage.Click += Usage_Click;
            // 
            // edit_area
            // 
            edit_area.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            edit_area.BorderStyle = BorderStyle.FixedSingle;
            edit_area.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            edit_area.Location = new Point(0, 34);
            edit_area.Name = "edit_area";
            edit_area.Size = new Size(1171, 516);
            edit_area.TabIndex = 1;
            edit_area.Text = "";
            edit_area.TextChanged += edit_area_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Saved_text
            // 
            Saved_text.Enabled = false;
            Saved_text.Location = new Point(644, 283);
            Saved_text.Name = "Saved_text";
            Saved_text.Size = new Size(150, 144);
            Saved_text.TabIndex = 2;
            Saved_text.Text = "";
            Saved_text.Visible = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 548);
            Controls.Add(Saved_text);
            Controls.Add(edit_area);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form6";
            Text = "Untitled - 文字編輯器";
            FormClosing += Form6_FormClosing;
            Load += Form6_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem NewFile;
        private ToolStripMenuItem SaveFile;
        private ToolStripMenuItem SaveNewFile;
        private ToolStripMenuItem 幫助ToolStripMenuItem;
        private ToolStripMenuItem About;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem Print;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 編輯ToolStripMenuItem;
        private ToolStripMenuItem Undo;
        private ToolStripMenuItem Redo;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem Cut;
        private ToolStripMenuItem Copy;
        private ToolStripMenuItem Paste;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem Delete;
        private ToolStripMenuItem Select_all;
        private ToolStripMenuItem 格式ToolStripMenuItem;
        private ToolStripMenuItem Font;
        private ToolStripMenuItem HighLight_text;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private ToolStripMenuItem Word_warp;
        private FontDialog fontDialog1;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem ExitForm;
        private ToolStripMenuItem Auto_save;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem Usage;
        private ToolStripMenuItem UnHighlight_text;
        private ToolStripMenuItem FontColor;
        private ToolStripMenuItem Reset;
        private ColorDialog colorDialog1;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem Find;
        protected RichTextBox edit_area;
        protected RichTextBox Saved_text;
    }
}