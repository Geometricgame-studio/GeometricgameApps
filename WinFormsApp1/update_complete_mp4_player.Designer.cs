namespace All_tools_Form_Apps
{
    partial class update_complete_mp4_player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_complete_mp4_player));
            player1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.Enabled = true;
            player1.Location = new Point(-1, 1);
            player1.Name = "player1";
            player1.OcxState = (AxHost.State)resources.GetObject("player1.OcxState");
            player1.Size = new Size(804, 452);
            player1.TabIndex = 0;
            player1.Visible = false;
            player1.PlayStateChange += player1_PlayStateChange;
            // 
            // update_complete_mp4_player
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(player1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "update_complete_mp4_player";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "更新完成動畫播放器";
            Load += update_complete_mp4_player_Load;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player1;
    }
}