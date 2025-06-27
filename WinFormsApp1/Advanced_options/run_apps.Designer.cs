namespace All_tools_Form_Apps.Additioinal_Forms
{
    partial class run_apps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(run_apps));
            label1 = new Label();
            textBox1 = new TextBox();
            browser = new Button();
            cancle = new Button();
            open = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(592, 28);
            label1.TabIndex = 0;
            label1.Text = "輸入應用程式的名稱或路徑，Gometcicgame 將為您開啟。";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "輸入路徑或名稱";
            textBox1.Size = new Size(667, 35);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // browser
            // 
            browser.FlatStyle = FlatStyle.System;
            browser.Location = new Point(553, 149);
            browser.Name = "browser";
            browser.Size = new Size(126, 34);
            browser.TabIndex = 2;
            browser.Text = "瀏覽(&B)";
            browser.UseVisualStyleBackColor = true;
            browser.Click += browser_Click;
            // 
            // cancle
            // 
            cancle.FlatStyle = FlatStyle.System;
            cancle.Location = new Point(421, 149);
            cancle.Name = "cancle";
            cancle.Size = new Size(126, 34);
            cancle.TabIndex = 3;
            cancle.Text = "取消";
            cancle.UseVisualStyleBackColor = true;
            cancle.Click += cancle_Click;
            // 
            // open
            // 
            open.Enabled = false;
            open.FlatStyle = FlatStyle.System;
            open.Location = new Point(289, 149);
            open.Name = "open";
            open.Size = new Size(126, 34);
            open.TabIndex = 4;
            open.Text = "開啟";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // run_apps
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 195);
            Controls.Add(open);
            Controls.Add(cancle);
            Controls.Add(browser);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "run_apps";
            Text = "執行";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button browser;
        private Button cancle;
        private Button open;
    }
}