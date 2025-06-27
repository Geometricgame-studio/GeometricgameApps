using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace All_tools_Form_Apps.Pop_up_windows
{
    public partial class GamesMenu : Form
    {
        public GamesMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            No_premiss();
        }

        private void No_premiss()
        {
            DialogResult result =
                    MessageBox.Show("您沒有權限使用功能 ⌈新增遊戲⌋ ，請向Geometricgame Studio™️" +
                    "申請權限後再試一次。", "您無權存取此功能", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Exclamation);
            if (result == DialogResult.Retry)
            {
                No_premiss();
            }
        }
        Form games;
        Boolean gameopened = false;
        private void game_bump_Click(object sender, EventArgs e)
        {
            gameopened = true;

            game_bump.Enabled = false;
            game_title_bump.ForeColor = Color.LightGray;
            games = new All_tools_Form_Apps.Games.Bomp_game.Bomp_game_main();
            games.Show();
        }

        private void GamesMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gameopened && games != null)
            {
                DialogResult result =
                    MessageBox.Show("您即將關閉遊戲選單，關閉遊戲選單會導致所有開啟的遊戲中斷，" +
                        "您確定嗎?", "關閉所有遊戲", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    games.Close();
                }
            }
        }

        private void game_bsodmaker_Click(object sender, EventArgs e)
        {
            gameopened = true;
            games = new All_tools_Form_Apps.Games.BSOD_maker();
            games.ShowDialog();
        }
    }
}
