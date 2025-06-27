using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class minecraft_hack : Form
    {
        public minecraft_hack()
        {
            InitializeComponent();

            start_action.Text = "不動作";
            start_key.Text = "未選擇";
        }

        private void repeat_times_CheckedChanged(object sender, EventArgs e)
        {
            if (repeat_times.Checked)
            {
                repeat_seconds.Checked = false;
                repeat_click.Checked = false;
            }
        }

        private void repeat_seconds_CheckedChanged(object sender, EventArgs e)
        {
            if (repeat_seconds.Checked)
            {
                repeat_times.Checked = false;
                repeat_click.Checked = false;
            }
        }

        private void repeat_click_CheckedChanged(object sender, EventArgs e)
        {
            if (repeat_click.Checked)
            {
                repeat_seconds.Checked = false;
                repeat_times.Checked = false;

                start_action.Text = "不動作";
                start_action.Enabled = false;
            }
            else
            {
                start_action.Enabled = true;
            }
        }

        private async void start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < start_delay.Value; i++)
            {
                start.Text = (start_delay.Value - i).ToString() + " 秒後開始";
                start.Enabled = false;
                await Task.Delay(1000);
            }
            //start.Enabled = true;
            //start.Text = "停止";

            start_hack();
        }

        private void start_hack()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < repeat_num.Value; i++)
            {
                SendKeys.SendWait("{UP}");
                SendKeys.SendWait("{ENTER}");

                await Task.Delay((int)repeat_ticks.Value);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            start.Text = "開始";
            start.Enabled = true;
        }

        private void click_repeat_time_CheckedChanged(object sender, EventArgs e)
        {
            if (click_repeat_time.Checked)
            {
                click_repeat_sec.Checked = false;
            }
        }

        private void click_repeat_sec_CheckedChanged(object sender, EventArgs e)
        {
            if (click_repeat_sec.Checked)
            {
                click_repeat_time.Checked = false;
            }
        }

        private async void start_clicking_Click(object sender, EventArgs e)
        {
            start_clicking.Enabled = false;
            for (int j = 0; j < clickstart_delay.Value; j++)
            {
                start_clicking.Text = clickstart_delay.Value - j + " 秒後開始";
                await Task.Delay(1000);
            }
            start_clicking.Text = "開始";
            start_clicking.Enabled = true;
            starts_auto_click();
        }

        Boolean click_stop = true;
        private async void starts_auto_click()
        {
            if (click_repeat_time.Checked)
            {
                for (int i = 0; i < click_repeat_times.Value; i++)
                {
                    Program.DoMouseClick();

                    await Task.Delay((int)click_ticks.Value);
                }
            }
            else
            {
                timer_count();
                while (click_stop == false)
                {
                    Program.DoMouseClick();

                    await Task.Delay((int)click_ticks.Value);
                }
            }
        }

        Boolean thread_stop = false;
        private async void timer_count()
        {
            click_stop = false;

            await Task.Delay((int)click_repeat_seconds.Value * 1000);

            click_stop = true;
        }

        int key;
        private async void keybind()
        {
            while (thread_stop == false)
            {
                await Task.Delay(5);

                int keyState = GetAsyncKeyState(key);

                if (keyState == 32769)
                {
                    starts_auto_click();
                }
            }
        }

        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(Int32 i);

        Thread kb;
        private void minecraft_hack_Load(object sender, EventArgs e)
        {
            kb = new Thread(keybind);
            kb.Start();
        }

        private void start_key_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start_key.SelectedIndex != 0)
            {
                key = char.Parse(start_key.SelectedItem.ToString());
            }
            else
            {
                key = 0;
            }
        }

        private void minecraft_hack_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread_stop = true;
            kb.Interrupt();
        }

        private async void start_walking_Click(object sender, EventArgs e)
        {
            await Task.Delay((int)start_walking_delay.Value * 1000);

            for (int i = 0; i < walking_sec.Value * 10; i++)
            {
                if (running.Checked == false)
                {
                    SendKeys.SendWait("W");
                }
                else
                {
                    SendKeys.SendWait("^W");
                }
                await Task.Delay(100);
            }
        }

        private async void start_spamming_Click(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            copy_use_text.SelectAll();
            copy_use_text.Copy();

            for (int i = 0; i < (int)ctrlv_int.Value; i++)
            {
                SendKeys.SendWait("^v");
                SendKeys.SendWait("{ENTER}");
                await Task.Delay((int)spam_delay.Value);
            }
        }
    }
}
