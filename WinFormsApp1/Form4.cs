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

using System.Runtime.InteropServices;
using System.Threading;
using Gma.System.MouseKeyHook;
using System.Reflection.Emit;

namespace All_tools_Form_Apps
{
    public partial class Form4 : Form
    {
        List<int> mx = new List<int>();
        List<int> my = new List<int>();
        List<Boolean> mclick = new List<Boolean>();

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Form4()
        {
            InitializeComponent();
            Play.Enabled = false;
            this.MaximizeBox = false;
        }

        Boolean Started = false;
        int frame = 0;
        Boolean click = false;
        private async void Start_Click(object sender, EventArgs e)
        {
            if (Started)
            {
                Started = false;
                Start.Text = "開始錄製(&S)";
                Start.Enabled = false;
                Play.Enabled = true;
                Timer.Text = "Stop " + frame;
                nowthing.Text = "錄製完成!";
                Program.show_notify("游標錄製器", "錄製已結束。", 1500, "info", false);
            }
            else
            {
                Started = true;
                Start.Text = "停止錄製(&S)";
                while (Started)
                {
                    mx.Add(MousePosition.X);
                    my.Add(MousePosition.Y);

                    if (mouseclick_now == false)
                    {
                        mclick.Add(false);
                    }
                    else
                    {
                        mouseclick_now = false;
                    }

                    await Task.Delay(1);
                    frame++;
                    Timer.Text = "Started " + frame;
                    nowthing.Text = "錄製中...";
                }
                nowthing.Text = "錄製完成!";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            mx.Clear();
            my.Clear();
            mclick.Clear();
            Start.Enabled = true;
            Play.Enabled = false;
            Timer.Text = "Ready to Start";
            nowthing.Text = "就緒";
            frame = 0;
        }
        Boolean pause = true;

        private async void Play_Click(object sender, EventArgs e)
        {
            Reset.Enabled = false;

            if (start_show_taskbar.Checked)
            {
                await Task.Delay(1000);
                SendKeys.SendWait("^{ESC}");
            }

            if (mx.Count > 0 && my.Count > 0)
            {
                if (pause == false)
                {
                    pause = true;
                    Timer.Text = "Pause " + frame;
                    nowthing.Text = "播放暫停";
                    Play.Text = "繼續播放(&P)";
                }
                else
                {
                    play_cursor();
                }
            }
            else
            {
                Play.Enabled = false;
            }
        }

        private async void play_cursor()
        {
            pause = false;
            Timer.Text = "Playing " + frame;
            nowthing.Text = "播放中...";
            Play.Text = "暫停播放(&P)";
            for (int i = 1; i < frame + 1; i++)
            {
                if (pause == false)
                {
                    Cursor.Position = new Point(mx[i - 1], my[i - 1]);
                    if (mclick[i - 1] == true)
                    {
                        DoMouseClick();
                    }
                    Timer.Text = "Playing " + i + " / " + frame;
                    await Task.Delay(1);
                }
            }
            Program.show_notify("游標錄製器", "播放已結束。", 1500, "info", false);
            Timer.Text = "Ready to Start";
            Play.Text = "播放(&P)";
            Reset.Enabled = true;
            nowthing.Text = "就緒";
            if (autoreplay == true)
            {
                nowthing.Text = "重複播放";
                decimal s = 0;
                for (int i = 0; i < Auto_replay_sec.Value; i++)
                {
                    s = Auto_replay_sec.Value - i;
                    Timer.Text = "Replay in " + s;
                    await Task.Delay(1000);
                }
                play_cursor();
            }
        }
        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private async void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            mx.Clear();
            my.Clear();
            mclick.Clear();
            Start.Enabled = false;
            Play.Enabled = false;
            Reset.Enabled = false;
            Timer.Text = "Closing Form...";
            nowthing.Text = "正在關閉...";
            frame = 0;

            kb.Interrupt();
        }

        Boolean autoreplay = false;
        private void Auto_replay_CheckedChanged(object sender, EventArgs e)
        {
            if (Auto_replay.Checked == true)
            {
                Auto_replay_sec.Enabled = true;
                autoreplay = true;
            }
            else
            {
                Auto_replay_sec.Enabled = false;
                autoreplay = true;
            }
        }

        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(Int32 i);

        int key = 88;

        Thread kb;
        private void Form4_Load(object sender, EventArgs e)
        {
            Hook.GlobalEvents().MouseClick += MouseClickAll;

            kb = new Thread(keybind);
            //kb.Start();
        }
        private async void keybind()
        {
            while (true) {
                await Task.Delay(5);

                int keyState = GetAsyncKeyState(key);

                if (keyState == 32769)
                {
                }
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT lpPoint);

        Boolean mouseclick_now = false;
        private void MouseClickAll(object sender, MouseEventArgs e)
        {
            mclick.Add(true);
            mouseclick_now = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
