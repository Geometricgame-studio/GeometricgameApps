namespace All_tools_Form_Apps.Pop_up_windows
{
    partial class GamesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesMenu));
            Exit = new Button();
            AddGame = new Button();
            game_bump = new PictureBox();
            game_title_bump = new Label();
            game_bsodmaker = new PictureBox();
            game_title_bsodmaker = new Label();
            ((System.ComponentModel.ISupportInitialize)game_bump).BeginInit();
            ((System.ComponentModel.ISupportInitialize)game_bsodmaker).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Exit.FlatStyle = FlatStyle.System;
            Exit.Location = new Point(12, 333);
            Exit.Name = "Exit";
            Exit.Size = new Size(575, 35);
            Exit.TabIndex = 2;
            Exit.Text = "關閉(&C)";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // AddGame
            // 
            AddGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddGame.FlatStyle = FlatStyle.System;
            AddGame.Location = new Point(586, 333);
            AddGame.Name = "AddGame";
            AddGame.Size = new Size(530, 35);
            AddGame.TabIndex = 3;
            AddGame.Text = "新增遊戲(&N)";
            AddGame.UseVisualStyleBackColor = true;
            AddGame.Click += AddGame_Click;
            // 
            // game_bump
            // 
            game_bump.Image = (Image)resources.GetObject("game_bump.Image");
            game_bump.Location = new Point(12, 12);
            game_bump.Name = "game_bump";
            game_bump.Size = new Size(110, 117);
            game_bump.SizeMode = PictureBoxSizeMode.Zoom;
            game_bump.TabIndex = 4;
            game_bump.TabStop = false;
            game_bump.Click += game_bump_Click;
            // 
            // game_title_bump
            // 
            game_title_bump.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            game_title_bump.Location = new Point(12, 132);
            game_title_bump.Name = "game_title_bump";
            game_title_bump.Size = new Size(110, 34);
            game_title_bump.TabIndex = 5;
            game_title_bump.Text = "彈力遊戲";
            game_title_bump.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // game_bsodmaker
            // 
            game_bsodmaker.Image = (Image)resources.GetObject("game_bsodmaker.Image");
            game_bsodmaker.Location = new Point(159, 12);
            game_bsodmaker.Name = "game_bsodmaker";
            game_bsodmaker.Size = new Size(110, 117);
            game_bsodmaker.SizeMode = PictureBoxSizeMode.Zoom;
            game_bsodmaker.TabIndex = 6;
            game_bsodmaker.TabStop = false;
            game_bsodmaker.Click += game_bsodmaker_Click;
            // 
            // game_title_bsodmaker
            // 
            game_title_bsodmaker.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            game_title_bsodmaker.Location = new Point(143, 132);
            game_title_bsodmaker.Name = "game_title_bsodmaker";
            game_title_bsodmaker.Size = new Size(141, 34);
            game_title_bsodmaker.TabIndex = 7;
            game_title_bsodmaker.Text = "BSOD訂製器";
            game_title_bsodmaker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GamesMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 377);
            Controls.Add(game_title_bsodmaker);
            Controls.Add(game_bsodmaker);
            Controls.Add(game_title_bump);
            Controls.Add(game_bump);
            Controls.Add(AddGame);
            Controls.Add(Exit);
            Name = "GamesMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "選擇遊戲";
            FormClosing += GamesMenu_FormClosing;
            ((System.ComponentModel.ISupportInitialize)game_bump).EndInit();
            ((System.ComponentModel.ISupportInitialize)game_bsodmaker).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Exit;
        private Button AddGame;
        private PictureBox game_bump;
        private Label game_title_bump;
        private PictureBox game_bsodmaker;
        private Label game_title_bsodmaker;
    }
}