using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Games.Bomp_game
{
    public partial class Bomp_game_main : Form
    {
        public Bomp_game_main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form bump = new Form();
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.balls > 9)
            {
                Program.show_notify("效能保護系統",
                    "由於召喚過多的彈力球會導致您的效能下降，為了維持您的效能良好" +
                    "，系統將禁止您在召喚彈力球。 如有不便，敬請見諒!",
                    2500, "error", false);
                button1.Enabled = false;
            }
            else
            {
                Program.balls++;
                bump = new All_tools_Form_Apps.Games.Bomp_game.Bomp_window();
                bump.Show();
            }
        }

        private async void Bomp_game_main_Load(object sender, EventArgs e)
        {
            while (true)
            {
                ball_count.Text = "目前球的數量" + Program.balls.ToString();
                await Task.Delay(10);
                if (Program.balls < 9)
                {
                    button1.Enabled = true;
                    
                }
                if (Program.balls < 1)
                {
                    exit.Enabled = true;
                }
            }
        }

        private void Bomp_game_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.balls > 0)
            {
                e.Cancel = true;
                Program.show_notify("彈力遊戲",
                    "您必須清除全部的彈力球才能關閉此視窗", 2500, "error", false);
                exit.Enabled = false;
            }
        }
    }
}
