namespace All_tools_Form_Apps
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            start = new Button();
            targetFolder = new TextBox();
            groupBox1 = new GroupBox();
            choose_result = new Button();
            resultFolder = new TextBox();
            choose_target = new Button();
            groupBox2 = new GroupBox();
            site_other_join = new TextBox();
            site_num = new NumericUpDown();
            slot_num = new NumericUpDown();
            remove_90 = new CheckBox();
            sitetext_join = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            text_2_filename = new TextBox();
            change_2_filename = new CheckBox();
            split_text = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)site_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot_num).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // start
            // 
            start.FlatStyle = FlatStyle.System;
            start.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            start.Location = new Point(12, 12);
            start.Name = "start";
            start.Size = new Size(776, 90);
            start.TabIndex = 0;
            start.Text = "改名";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // targetFolder
            // 
            targetFolder.Location = new Point(6, 32);
            targetFolder.Name = "targetFolder";
            targetFolder.PlaceholderText = "目標資料夾";
            targetFolder.Size = new Size(677, 33);
            targetFolder.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(choose_result);
            groupBox1.Controls.Add(resultFolder);
            groupBox1.Controls.Add(choose_target);
            groupBox1.Controls.Add(targetFolder);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 117);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "檔案設定";
            // 
            // choose_result
            // 
            choose_result.FlatStyle = FlatStyle.System;
            choose_result.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            choose_result.Location = new Point(689, 71);
            choose_result.Name = "choose_result";
            choose_result.Size = new Size(81, 34);
            choose_result.TabIndex = 4;
            choose_result.Text = "選擇...";
            choose_result.UseVisualStyleBackColor = true;
            choose_result.Click += choose_result_Click;
            // 
            // resultFolder
            // 
            resultFolder.Location = new Point(6, 71);
            resultFolder.Name = "resultFolder";
            resultFolder.PlaceholderText = "輸出資料夾";
            resultFolder.Size = new Size(677, 33);
            resultFolder.TabIndex = 3;
            // 
            // choose_target
            // 
            choose_target.FlatStyle = FlatStyle.System;
            choose_target.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            choose_target.Location = new Point(689, 32);
            choose_target.Name = "choose_target";
            choose_target.Size = new Size(81, 34);
            choose_target.TabIndex = 2;
            choose_target.Text = "選擇...";
            choose_target.UseVisualStyleBackColor = true;
            choose_target.Click += choose_target_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(site_other_join);
            groupBox2.Controls.Add(site_num);
            groupBox2.Controls.Add(slot_num);
            groupBox2.Controls.Add(remove_90);
            groupBox2.Controls.Add(sitetext_join);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            groupBox2.Location = new Point(12, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 117);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "檔名設定";
            // 
            // site_other_join
            // 
            site_other_join.Location = new Point(575, 33);
            site_other_join.Name = "site_other_join";
            site_other_join.PlaceholderText = "加入字串";
            site_other_join.Size = new Size(195, 33);
            site_other_join.TabIndex = 9;
            // 
            // site_num
            // 
            site_num.Location = new Point(134, 33);
            site_num.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            site_num.Name = "site_num";
            site_num.Size = new Size(106, 33);
            site_num.TabIndex = 8;
            site_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // slot_num
            // 
            slot_num.Location = new Point(369, 76);
            slot_num.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            slot_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            slot_num.Name = "slot_num";
            slot_num.Size = new Size(68, 33);
            slot_num.TabIndex = 7;
            slot_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // remove_90
            // 
            remove_90.Checked = true;
            remove_90.CheckState = CheckState.Checked;
            remove_90.FlatStyle = FlatStyle.System;
            remove_90.Location = new Point(6, 71);
            remove_90.Name = "remove_90";
            remove_90.Size = new Size(505, 40);
            remove_90.TabIndex = 6;
            remove_90.Text = "刪除日期欄位的括號 欄位編號倒數第                   個\r\n";
            remove_90.UseVisualStyleBackColor = true;
            // 
            // sitetext_join
            // 
            sitetext_join.Location = new Point(296, 32);
            sitetext_join.Name = "sitetext_join";
            sitetext_join.PlaceholderText = "要加入的字串";
            sitetext_join.Size = new Size(195, 33);
            sitetext_join.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(564, 25);
            label1.TabIndex = 4;
            label1.Text = "當Site編號為                       加入                                            其餘的";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(text_2_filename);
            groupBox3.Controls.Add(change_2_filename);
            groupBox3.Controls.Add(split_text);
            groupBox3.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 136);
            groupBox3.Location = new Point(12, 354);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 117);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "屬性設定";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 8;
            label3.Text = "分隔符號";
            // 
            // text_2_filename
            // 
            text_2_filename.Enabled = false;
            text_2_filename.Location = new Point(316, 70);
            text_2_filename.Name = "text_2_filename";
            text_2_filename.PlaceholderText = "新的副檔名";
            text_2_filename.Size = new Size(207, 33);
            text_2_filename.TabIndex = 7;
            // 
            // change_2_filename
            // 
            change_2_filename.AutoSize = true;
            change_2_filename.Enabled = false;
            change_2_filename.FlatStyle = FlatStyle.System;
            change_2_filename.Location = new Point(6, 71);
            change_2_filename.Name = "change_2_filename";
            change_2_filename.Size = new Size(324, 30);
            change_2_filename.TabIndex = 6;
            change_2_filename.Text = "更改副檔名(可能無法正常開啟)";
            change_2_filename.UseVisualStyleBackColor = true;
            // 
            // split_text
            // 
            split_text.Location = new Point(115, 32);
            split_text.Name = "split_text";
            split_text.PlaceholderText = "分隔符號";
            split_text.Size = new Size(655, 33);
            split_text.TabIndex = 1;
            split_text.Text = "_";
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form17";
            Text = "批量檔案改名器";
            Load += Form17_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)site_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot_num).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private TextBox targetFolder;
        private GroupBox groupBox1;
        private Button choose_target;
        private Button choose_result;
        private TextBox resultFolder;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox sitetext_join;
        private CheckBox remove_90;
        private GroupBox groupBox3;
        private CheckBox change_2_filename;
        private TextBox textBox1;
        private TextBox split_text;
        private TextBox text_2_filename;
        private NumericUpDown slot_num;
        private Label label2;
        private NumericUpDown site_num;
        private TextBox site_other_join;
        private Label label3;
    }
}