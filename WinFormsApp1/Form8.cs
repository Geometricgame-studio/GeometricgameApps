using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class Form8 : Form
    {
        List<string> good_text = new List<string>();
        List<string> bad_text = new List<string>();
        List<string> title_text = new List<string>();
        public Form8()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            title_text.Add("這隻喵今天有沒有很棒?");
            good_text.Add("有");
            bad_text.Add("沒有");
            title_text.Add("你有沒有愛這隻喵?");
            good_text.Add("有");
            bad_text.Add("沒有");
            title_text.Add("請問你喜歡這隻喵嗎?");
            good_text.Add("喜歡");
            bad_text.Add("不喜歡");
            title_text.Add("這隻喵今天有沒有要改進的地方?");
            good_text.Add("沒有");
            bad_text.Add("有");
            title_text.Add("你有真心理會這隻喵嗎?");
            good_text.Add("有");
            bad_text.Add("沒有");
            next();
        }

        int score = 0;
        int question = 0;
        private void Good_Click(object sender, EventArgs e)
        {
            score++;
            next();
        }

        private void Bad_Click(object sender, EventArgs e)
        {
            score--;
            next();
        }

        private async void next()
        {
            if (question == title_text.Count)
            {
                complete();
            }
            else
            {
                question++;
                Good.Enabled = false;
                Bad.Enabled = false;
                Good.Text = good_text[question - 1];
                Bad.Text = bad_text[question - 1];
                title.Text = "問題 " + ((int)title_text.Count) + "/"
                    + question + "\n" + title_text[question - 1];
                await Task.Delay(1000);
                Good.Enabled = true;
                Bad.Enabled = true;
            }
        }

        private void complete()
        {
            title.Text = "答題完成!";
            if ((score + title_text.Count) > 5)
            {
                Program.show_notify("喵星系統", "答題完成! 這隻喵感謝你評喵星喔!", 1500, "info", false);
            }
            else
            {
                Program.show_notify("喵星系統", "分數 " + (score + title_text.Count).ToString() + " 似乎有點低，要更改分數嗎?",
                    2500, "error", false);
            }
            entered_score.Maximum = title_text.Count * 2;
            entered_score.Value = title_text.Count * 2;
            Good.Visible = false;
            Bad.Visible = false;
            scores.Visible = true;
            Enter_score.Visible = true;
            Exit.Visible = true;
            scores.Text = "正在結算分數，請稍後...";
            scores.Text = "感謝您抽空填寫問卷，系統預估您的評分是\n" + ((int)title_text.Count * 2) + "/"
                + ((int)score + title_text.Count) +
                "\n請拿給Ryan看此頁面!";
        }

        private async void Enter_score_Click(object sender, EventArgs e)
        {
            if (Enter_score.Text == "如果系統預測錯誤，請按此。")
            {
                Enter_score.Text = "完成";
                entered_score.Visible = true;
                Program.show_notify("喵星系統", "您想要更改這隻喵的分數嗎? 記得不要改得太爛!", 2500, "warning", false);
            }
            else
            {
                if (entered_score.Value > -1 && entered_score.Value < title_text.Count + 1)
                {
                    Enter_score.Visible = false;
                    entered_score.Visible = false;
                    scores.Text = "修改分數中...";
                    scores.Text = "您的評分是\n" + ((int)title_text.Count * 2) + "/" + entered_score.Value + "\n請拿給Ryan看此頁面!";
                }
                else
                {
                    Enter_score.Text = "您輸入的分數有誤!";
                    await Task.Delay(1000);
                    Enter_score.Text = "完成";
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
