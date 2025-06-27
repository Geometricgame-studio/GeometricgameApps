using System.Threading.Tasks;
using System.Media;

namespace Tomato_clock
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private async Task countdown(int second, string action, Boolean countup)
        {
            foucing = true;

            draw_init();

            string title = "";
            double left = second;
            int i = 0;
            while (i < second * 5)
            {
                i++;
                left -= 0.2;

                if (countup) title = "正在食用你的番茄...";
                else title = "番茄成熟中...";
                if (left < second * 0.5)
                {
                    if (countup) title = "正在食用你的番茄...";
                    else title = "你的番茄半熟了...";
                }
                if (i / 5 < 10)
                {
                    if (countup) title = "正在烹煮你的番茄...";
                    else title = "正在種植你的番茄...";
                }
                if (left < second * 0.25)
                {
                    if (countup) title = "要吃完了...";
                    else title = "你的番茄要熟了...";
                }
                if (left < second * 0.1)
                {
                    if (countup) title = "肚子即將撐飽...";
                    else title = "正在摘採你的番茄...";
                }
                text_timer.Text = title + "\n" + action + "中\n還剩下: " + add_zero(Math.Floor((Math.Round(left) / 60))) + ":" + add_zero(Math.Round(left) % 60);

                if (countup) draw_tomato(second, second - left);
                else draw_pie(second, second - left);

                await Task.Delay(200);

                while (paused)
                {
                    await Task.Delay(500);

                    if (stoped)
                    {
                        break;
                    }
                }

                if (stoped)
                {
                    break;
                }
            }

            if (countup) text_timer.Text = "番茄吃的一乾二淨!\n" + action + "結束";
            else text_timer.Text = "你的番茄可以吃啦!\n" + action + "結束";
        }

        private string add_zero(double input)
        {
            if (input < 10)
            {
                return "0" + input;
            }
            else
            {
                return input.ToString();
            }

            return "ERR";
        }

        private void draw_ready()
        {
            Graphics g = Graphics.FromHwnd(foucsing.Handle);
            Rectangle rect = new Rectangle(0, 50, 350, 350);

            g.Clear(SystemColors.Control);
            draw_init();
            g.FillPie(new SolidBrush(ColorTranslator.FromHtml("#6CF543")), rect, 270, 360);
        }

        private void draw_init()
        {
            Graphics g = Graphics.FromHwnd(foucsing.Handle);

            g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(172, 0, 6, 60));
            g.FillRectangle(new SolidBrush(Color.LightGreen), new Rectangle(178, 20, 50, 15));
        }

        private void draw_pie(double total, double sub)
        {
            double persan = sub / total * 360;

            Graphics g = Graphics.FromHwnd(foucsing.Handle);
            Rectangle rect = new Rectangle(0, 50, 350, 350);

            g.FillPie(new SolidBrush(ColorTranslator.FromHtml("#F59F08")), rect, 270, (float)persan);
            g.FillPie(new SolidBrush(ColorTranslator.FromHtml("#F5C607")), rect, 270 + (float)persan, 360 - (float)persan);

            if (persan > 359.9)
            {
                g.Clear(SystemColors.Control);
                draw_init();
                g.FillPie(new SolidBrush(ColorTranslator.FromHtml("#F43623")), rect, 270, 360);
            }
        }

        private void draw_tomato(double total, double sub)
        {
            double persan = 1 - sub / total;

            Graphics g = Graphics.FromHwnd(foucsing.Handle);
            Rectangle rect = new Rectangle(0, 50, 350, 350);

            g.FillPie(new SolidBrush(ColorTranslator.FromHtml("#F43623")), rect, 0, 360);
            foucsing.Size = new Size((int)(350 * persan), 460);

            if (persan > 99.9)
            {
                g.Clear(SystemColors.Control);
                foucsing.Size = new Size(350, 460);
            }
        }

        Boolean foucing = false;
        Boolean paused = false;
        private async void start_Click(object sender, EventArgs e)
        {
            if (foucing)
            {
                if (paused)
                {
                    paused = false;
                    start.Text = "■ 暫停";
                }
                else
                {
                    paused = true;
                    start.Text = "→ 繼續";
                }
            }
            else
            {
                paused = false;
                stoped = false;
                start.Text = "■ 暫停";
                stop.Enabled = true;
                rest_mins.Enabled = false;
                mins.Enabled = false;
                repeats.Enabled = false;

                for (int i = 0; i < (int)repeats.Value; i++)
                {
                    notifyIcon1.ShowBalloonTip(3000, "專注階段已開始!", "您已開始為期" + (int)mins.Value + "分鐘的專注行程", ToolTipIcon.Info);

                    await countdown((int)mins.Value * 60, "專注", false);

                    notifyIcon1.ShowBalloonTip(3000, "專注階段已結束!", "恭喜您完成為期" + (int)mins.Value + "分鐘的專注行程", ToolTipIcon.Info);

                    await Task.Delay(3000);

                    notifyIcon1.ShowBalloonTip(3000, "開始休息囉!", "為期" + (int)mins.Value + "分鐘的休息時間已開始，離開座位，好好放鬆自我吧!", ToolTipIcon.Info);

                    await countdown((int)rest_mins.Value * 60, "休息", true);

                    notifyIcon1.ShowBalloonTip(3000, "休息時間到!", "為期" + (int)mins.Value + "分鐘的休息時間已結束，打起精神，繼續專注吧!", ToolTipIcon.Info);

                    await Task.Delay(3000);
                }

                text_timer.Text = "我已經吃了" + (int)repeats.Value + "顆番茄了\n今天真是美好的一天 :)";

                paused = false;
                start.Text = "↑ 種植番茄 ↑";
                stop.Enabled = true;
                foucing = false;
                rest_mins.Enabled = true;
                mins.Enabled = true;
                repeats.Enabled = true;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                draw_init();
            }
        }

        Boolean stoped = false;
        private void stop_Click(object sender, EventArgs e)
        {
            stoped = true;
            stop.Enabled = false;
            rest_mins.Enabled = true;
            mins.Enabled = true;
            repeats.Enabled = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(25);
            draw_ready();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void show_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void force_exit_Click(object sender, EventArgs e)
        {
            this.Show();
            exit.PerformClick();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }
        }
    }
}
