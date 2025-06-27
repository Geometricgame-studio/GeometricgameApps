namespace All_tools_Form_Apps.MessageBoxs
{
    partial class Update_confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_confirm));
            label1 = new Label();
            version = new Label();
            exit = new Button();
            update = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 50);
            label1.TabIndex = 0;
            label1.Text = "有新的版本可用!";
            // 
            // version
            // 
            version.AutoSize = true;
            version.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            version.Location = new Point(22, 59);
            version.Name = "version";
            version.Size = new Size(242, 72);
            version.TabIndex = 1;
            version.Text = "最新版本: 載入中...\r\n目前版本: 載入中...";
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exit.FlatStyle = FlatStyle.System;
            exit.Location = new Point(617, 219);
            exit.Name = "exit";
            exit.Size = new Size(171, 53);
            exit.TabIndex = 2;
            exit.Text = "下次再說 (&N)";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // update
            // 
            update.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            update.FlatStyle = FlatStyle.System;
            update.Location = new Point(12, 219);
            update.Name = "update";
            update.Size = new Size(171, 53);
            update.TabIndex = 1;
            update.Text = "現在更新 (&U)";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // Update_confirm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 284);
            Controls.Add(update);
            Controls.Add(exit);
            Controls.Add(version);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Update_confirm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "有新的更新可用!";
            Load += Update_confirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label version;
        private Button exit;
        private Button update;
    }
}