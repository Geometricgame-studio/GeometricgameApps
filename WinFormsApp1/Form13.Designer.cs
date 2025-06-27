namespace All_tools_Form_Apps
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            groupBox1 = new GroupBox();
            To = new NumericUpDown();
            label1 = new Label();
            From = new NumericUpDown();
            repeat_choose = new CheckBox();
            auto_repeat = new CheckBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            repeat_number = new NumericUpDown();
            Picker = new Label();
            change_font = new Button();
            fontDialog1 = new FontDialog();
            Reset_font = new Button();
            PICK = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)From).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repeat_number).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(To);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(From);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "範圍";
            // 
            // To
            // 
            To.Location = new Point(40, 70);
            To.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            To.Name = "To";
            To.Size = new Size(278, 30);
            To.TabIndex = 2;
            To.Value = new decimal(new int[] { 100, 0, 0, 0 });
            To.ValueChanged += To_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 69);
            label1.TabIndex = 1;
            label1.Text = "從\r\n\r\n到";
            // 
            // From
            // 
            From.Location = new Point(40, 29);
            From.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            From.Name = "From";
            From.Size = new Size(278, 30);
            From.TabIndex = 1;
            From.Value = new decimal(new int[] { 1, 0, 0, 0 });
            From.ValueChanged += From_ValueChanged;
            // 
            // repeat_choose
            // 
            repeat_choose.AutoSize = true;
            repeat_choose.Location = new Point(12, 153);
            repeat_choose.Name = "repeat_choose";
            repeat_choose.Size = new Size(108, 27);
            repeat_choose.TabIndex = 1;
            repeat_choose.Text = "重複選號";
            repeat_choose.UseVisualStyleBackColor = true;
            // 
            // auto_repeat
            // 
            auto_repeat.AutoSize = true;
            auto_repeat.Checked = true;
            auto_repeat.CheckState = CheckState.Checked;
            auto_repeat.Location = new Point(12, 186);
            auto_repeat.Name = "auto_repeat";
            auto_repeat.Size = new Size(108, 27);
            auto_repeat.TabIndex = 2;
            auto_repeat.Text = "自動循環";
            auto_repeat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(repeat_number);
            groupBox2.Location = new Point(12, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 77);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "抽號設定";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 1;
            label2.Text = "中獎人數";
            // 
            // repeat_number
            // 
            repeat_number.Location = new Point(94, 29);
            repeat_number.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            repeat_number.Name = "repeat_number";
            repeat_number.Size = new Size(281, 30);
            repeat_number.TabIndex = 1;
            repeat_number.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Picker
            // 
            Picker.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Picker.Location = new Point(571, 82);
            Picker.Name = "Picker";
            Picker.Size = new Size(409, 200);
            Picker.TabIndex = 4;
            Picker.Text = "Number Picker";
            Picker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // change_font
            // 
            change_font.FlatStyle = FlatStyle.System;
            change_font.Location = new Point(12, 335);
            change_font.Name = "change_font";
            change_font.Size = new Size(225, 34);
            change_font.TabIndex = 5;
            change_font.Text = "更換字體(&F)";
            change_font.UseVisualStyleBackColor = true;
            change_font.Click += change_font_Click;
            // 
            // Reset_font
            // 
            Reset_font.FlatStyle = FlatStyle.System;
            Reset_font.Location = new Point(243, 335);
            Reset_font.Name = "Reset_font";
            Reset_font.Size = new Size(150, 34);
            Reset_font.TabIndex = 6;
            Reset_font.Text = "重置字體(&R)";
            Reset_font.UseVisualStyleBackColor = true;
            Reset_font.Click += Reset_font_Click;
            // 
            // PICK
            // 
            PICK.FlatStyle = FlatStyle.System;
            PICK.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            PICK.Location = new Point(12, 375);
            PICK.Name = "PICK";
            PICK.Size = new Size(375, 63);
            PICK.TabIndex = 7;
            PICK.Text = "選號(&P)";
            PICK.UseVisualStyleBackColor = true;
            PICK.Click += PICK_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 450);
            Controls.Add(PICK);
            Controls.Add(Reset_font);
            Controls.Add(change_font);
            Controls.Add(Picker);
            Controls.Add(groupBox2);
            Controls.Add(auto_repeat);
            Controls.Add(repeat_choose);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form13";
            Text = "選號器";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)To).EndInit();
            ((System.ComponentModel.ISupportInitialize)From).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)repeat_number).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown From;
        private NumericUpDown To;
        private CheckBox repeat_choose;
        private CheckBox auto_repeat;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown repeat_number;
        private Label Picker;
        private Button change_font;
        private FontDialog fontDialog1;
        private Button Reset_font;
        private Button PICK;
    }
}