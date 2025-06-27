namespace All_tools_Form_Apps
{
    partial class Form21
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
            treeView1 = new TreeView();
            listView1 = new ListView();
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            Delete_file = new ToolStripMenuItem();
            Move_file = new ToolStripMenuItem();
            rename_file = new ToolStripMenuItem();
            Copy_file = new ToolStripMenuItem();
            Cut_file = new ToolStripMenuItem();
            Paste_file = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            Find_file = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exit = new ToolStripMenuItem();
            folder_path = new TextBox();
            Back_to_top = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Location = new Point(0, 78);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(445, 613);
            treeView1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(451, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(984, 613);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1435, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Delete_file, Move_file, rename_file, Copy_file, Cut_file, Paste_file, toolStripMenuItem2, Find_file, toolStripMenuItem1, exit });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(62, 27);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // Delete_file
            // 
            Delete_file.Name = "Delete_file";
            Delete_file.ShortcutKeys = Keys.Delete;
            Delete_file.Size = new Size(217, 34);
            Delete_file.Text = "刪除";
            Delete_file.Click += Delete_file_Click;
            // 
            // Move_file
            // 
            Move_file.Name = "Move_file";
            Move_file.ShortcutKeys = Keys.Control | Keys.M;
            Move_file.Size = new Size(217, 34);
            Move_file.Text = "移動";
            // 
            // rename_file
            // 
            rename_file.Name = "rename_file";
            rename_file.ShortcutKeys = Keys.F2;
            rename_file.Size = new Size(217, 34);
            rename_file.Text = "重新命名";
            // 
            // Copy_file
            // 
            Copy_file.Name = "Copy_file";
            Copy_file.ShortcutKeys = Keys.Control | Keys.C;
            Copy_file.Size = new Size(217, 34);
            Copy_file.Text = "複製";
            // 
            // Cut_file
            // 
            Cut_file.Name = "Cut_file";
            Cut_file.ShortcutKeys = Keys.Control | Keys.X;
            Cut_file.Size = new Size(217, 34);
            Cut_file.Text = "剪下";
            // 
            // Paste_file
            // 
            Paste_file.Name = "Paste_file";
            Paste_file.ShortcutKeys = Keys.Control | Keys.V;
            Paste_file.Size = new Size(217, 34);
            Paste_file.Text = "貼上";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(214, 6);
            // 
            // Find_file
            // 
            Find_file.Name = "Find_file";
            Find_file.ShortcutKeys = Keys.Control | Keys.F;
            Find_file.Size = new Size(217, 34);
            Find_file.Text = "尋找";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(214, 6);
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.ShortcutKeyDisplayString = "";
            exit.ShortcutKeys = Keys.Alt | Keys.F4;
            exit.Size = new Size(217, 34);
            exit.Text = "結束";
            exit.Click += exit_Click;
            // 
            // folder_path
            // 
            folder_path.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            folder_path.BorderStyle = BorderStyle.FixedSingle;
            folder_path.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            folder_path.Location = new Point(183, 35);
            folder_path.Name = "folder_path";
            folder_path.PlaceholderText = "輸入路徑...";
            folder_path.Size = new Size(1252, 38);
            folder_path.TabIndex = 3;
            folder_path.KeyDown += folder_path_KeyDown;
            // 
            // Back_to_top
            // 
            Back_to_top.BackColor = SystemColors.ButtonHighlight;
            Back_to_top.FlatStyle = FlatStyle.Flat;
            Back_to_top.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Back_to_top.Location = new Point(2, 35);
            Back_to_top.Name = "Back_to_top";
            Back_to_top.Size = new Size(42, 39);
            Back_to_top.TabIndex = 4;
            Back_to_top.Text = "↑";
            Back_to_top.UseVisualStyleBackColor = false;
            Back_to_top.Click += Back_to_top_Click;
            // 
            // Form21
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1435, 691);
            Controls.Add(Back_to_top);
            Controls.Add(folder_path);
            Controls.Add(menuStrip1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Form21";
            Text = "Geometricgame 檔案總管";
            Load += Form21_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem Delete_file;
        private ToolStripMenuItem Move_file;
        private ToolStripMenuItem rename_file;
        private ToolStripMenuItem Copy_file;
        private ToolStripMenuItem Cut_file;
        private ToolStripMenuItem Paste_file;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem Find_file;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exit;
        private TextBox folder_path;
        private Button Back_to_top;
    }
}