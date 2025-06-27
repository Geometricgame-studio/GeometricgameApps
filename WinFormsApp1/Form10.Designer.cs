namespace All_tools_Form_Apps
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            Add_alarm = new Button();
            pictureBox1 = new PictureBox();
            Alarm_table = new TableLayoutPanel();
            All_alarm_title = new Label();
            TimePicker = new DateTimePicker();
            alarm_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Add_alarm
            // 
            Add_alarm.ImageKey = "(none)";
            Add_alarm.Location = new Point(81, 564);
            Add_alarm.Name = "Add_alarm";
            Add_alarm.Size = new Size(154, 49);
            Add_alarm.TabIndex = 0;
            Add_alarm.Text = "新增鬧鐘";
            Add_alarm.UseVisualStyleBackColor = true;
            Add_alarm.Click += Add_alarm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 564);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Alarm_table
            // 
            Alarm_table.ColumnCount = 1;
            Alarm_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Alarm_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Alarm_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Alarm_table.Location = new Point(12, 63);
            Alarm_table.Name = "Alarm_table";
            Alarm_table.RowCount = 1;
            Alarm_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Alarm_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Alarm_table.Size = new Size(776, 495);
            Alarm_table.TabIndex = 2;
            // 
            // All_alarm_title
            // 
            All_alarm_title.AutoSize = true;
            All_alarm_title.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            All_alarm_title.Location = new Point(12, 30);
            All_alarm_title.Name = "All_alarm_title";
            All_alarm_title.Size = new Size(109, 30);
            All_alarm_title.TabIndex = 3;
            All_alarm_title.Text = "所有鬧鐘";
            // 
            // TimePicker
            // 
            TimePicker.CalendarFont = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.Location = new Point(12, 619);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(223, 30);
            TimePicker.TabIndex = 4;
            // 
            // alarm_name
            // 
            alarm_name.Location = new Point(241, 619);
            alarm_name.Name = "alarm_name";
            alarm_name.PlaceholderText = "鬧鐘名稱";
            alarm_name.Size = new Size(547, 30);
            alarm_name.TabIndex = 0;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 661);
            Controls.Add(alarm_name);
            Controls.Add(TimePicker);
            Controls.Add(All_alarm_title);
            Controls.Add(Alarm_table);
            Controls.Add(pictureBox1);
            Controls.Add(Add_alarm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form10";
            Text = "鬧鐘";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_alarm;
        private PictureBox pictureBox1;
        private TableLayoutPanel Alarm_table;
        private Label All_alarm_title;
        private DateTimePicker TimePicker;
        private TextBox alarm_name;
    }
}