namespace All_tools_Form_Apps.Additioinal_Forms
{
    partial class Error_shower_infos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_shower_infos));
            exit = new Button();
            texts = new Label();
            adv_info = new Button();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exit.FlatStyle = FlatStyle.System;
            exit.Location = new Point(723, 146);
            exit.Name = "exit";
            exit.Size = new Size(112, 34);
            exit.TabIndex = 0;
            exit.Text = "確定 (&O)";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // texts
            // 
            texts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            texts.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            texts.Location = new Point(12, 9);
            texts.Name = "texts";
            texts.Size = new Size(823, 134);
            texts.TabIndex = 1;
            texts.Text = "詳細資料";
            // 
            // adv_info
            // 
            adv_info.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            adv_info.FlatStyle = FlatStyle.System;
            adv_info.Location = new Point(12, 146);
            adv_info.Name = "adv_info";
            adv_info.Size = new Size(226, 34);
            adv_info.TabIndex = 2;
            adv_info.Text = "更詳細的資料 (&D)";
            adv_info.UseVisualStyleBackColor = true;
            adv_info.Click += adv_info_Click;
            // 
            // Error_shower_infos
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 192);
            Controls.Add(adv_info);
            Controls.Add(texts);
            Controls.Add(exit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Error_shower_infos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "錯誤詳細資料";
            ResumeLayout(false);
        }

        #endregion

        private Button exit;
        private Label texts;
        private Button adv_info;
    }
}