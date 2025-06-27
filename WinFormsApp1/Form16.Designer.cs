namespace All_tools_Form_Apps
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            groupBox1 = new GroupBox();
            compute_primes = new Button();
            label1 = new Label();
            pri_numbers_input2 = new NumericUpDown();
            pri_numbers_input1 = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pri_numbers_input2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pri_numbers_input1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(compute_primes);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pri_numbers_input2);
            groupBox1.Controls.Add(pri_numbers_input1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "計算質數";
            // 
            // compute_primes
            // 
            compute_primes.FlatStyle = FlatStyle.Flat;
            compute_primes.Location = new Point(6, 85);
            compute_primes.Name = "compute_primes";
            compute_primes.Size = new Size(764, 53);
            compute_primes.TabIndex = 1;
            compute_primes.Text = "找出質數";
            compute_primes.UseVisualStyleBackColor = true;
            compute_primes.Click += compute_primes_Click;
            // 
            // label1
            // 
            label1.Location = new Point(314, 43);
            label1.Name = "label1";
            label1.Size = new Size(148, 34);
            label1.TabIndex = 2;
            label1.Text = "到";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pri_numbers_input2
            // 
            pri_numbers_input2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pri_numbers_input2.Location = new Point(468, 42);
            pri_numbers_input2.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            pri_numbers_input2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pri_numbers_input2.Name = "pri_numbers_input2";
            pri_numbers_input2.Size = new Size(302, 37);
            pri_numbers_input2.TabIndex = 1;
            pri_numbers_input2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // pri_numbers_input1
            // 
            pri_numbers_input1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pri_numbers_input1.Location = new Point(6, 42);
            pri_numbers_input1.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            pri_numbers_input1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pri_numbers_input1.Name = "pri_numbers_input1";
            pri_numbers_input1.Size = new Size(302, 37);
            pri_numbers_input1.TabIndex = 0;
            pri_numbers_input1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form16";
            Text = "進階計算機";
            Load += Form16_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pri_numbers_input2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pri_numbers_input1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown pri_numbers_input1;
        private NumericUpDown pri_numbers_input2;
        private Label label1;
        private Button compute_primes;
    }
}