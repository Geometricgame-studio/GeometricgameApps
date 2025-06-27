using All_tools_Form_Apps.Games.Bomp_game;
using Microsoft.Win32;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using WinFormsApp1;

namespace All_tools_Form_Apps
{
    internal static class Program
    {
        public static string version = "Release 1.3.43";
        //Form2
        public static Form2 x = new Form2();


        public static bool lasttool_ok = true;
        public static bool shutdown_ok = true;
        public static bool open_clicker_ok = true;
        public static bool computeer_ok = true;
        public static bool send_email_ok = true;
        public static bool alarm_ok = true;
        public static bool clock_ok = true;
        public static bool games_ok = true;
        public static bool media_player_ok = true;
        public static bool youtube_downloader_ok = true;
        public static bool number_picker_ok = true;
        public static bool browser_ok = true;
        public static bool notepad_ok = true;

        //Apps public settings:
        public static Form main_forms = new Form2();
        public static bool startup_video_on = false;
        public static Font defalut_fonts = new Font("Microsoft JhengHei UI", 11);
        public static void apply_public_settings()
        {
            main_forms.Font = defalut_fonts;
        }

        //Bump_window Forms:
        public static Bomp_window bomp_Window = new Bomp_window();
        public static int balls;

        //Notify:
        private static List<string> titles = new List<string>();
        private static List<string> texts = new List<string>();
        private static List<int> closes = new List<int>();
        private static List<string> types = new List<string>();
        private static List<bool> foucses = new List<bool>();
        private static bool notify_show = false;

        public static void system_notify(int timeout, string title, string conten, ToolTipIcon icon)
        {
            NotifyIcon ni = new NotifyIcon();
            ni.BalloonTipClicked += Ni_BalloonTipClicked;
            ni.ShowBalloonTip(10000, title, conten, icon);
        }

        private static void Ni_BalloonTipClicked(object? sender, EventArgs e)
        {
        }

        //setting-App_onoff
        public static string password = "";

        //Mouseclick_mod (Program)
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        //Taskmgr_process_start_factory
        public static List<Form> tasks_form = new List<Form>();
        public static List<string> tasks_name = new List<string>();
        public static void newtask(Form forms, string names, bool dialogmode, bool justreg, bool save_forms, bool check_single)
        {
            if (justreg)
            {
                tasks_name.Add(names);
                tasks_form.Add(forms);
            }
            else
            {
                if (save_forms)
                {
                    Form f = forms;
                    tasks_name.Add(names);
                    tasks_form.Add(f);

                    if (dialogmode)
                    {
                        f.ShowDialog();
                    }
                    else
                    {
                        f.Show();
                    }
                }
                else
                {
                    if (dialogmode)
                    {
                        forms.ShowDialog();
                    }
                    else
                    {
                        forms.Show();
                    }
                }
            }
        }

        //show_error_infoer
        public static void show_errors(Exception ex, string title, string text)
        {
            Form errf = new Error_shower(ex, title, text);
            errf.TopMost = true;
            errf.WindowState = FormWindowState.Minimized;
            errf.ShowDialog();
        }

        //--Addnational code END--

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new LoadingForm());
            }
            catch (Exception ex)
            {
                new Error_shower(ex, "應用程式發生未預期的錯誤!").ShowDialog();
            }
        }
        public static DialogResult show_msgbox(string title, string text, string icon, string type)
        {
            Form msgbox = new Form();
            if (type == "OK")
            {
                msgbox = new MessageBoxs.OK_MessageBox(text, title, icon);
                msgbox.ShowDialog();
            }
            else if (type == "OKCancle")
            {
                msgbox = new MessageBoxs.OKCancle_MessageBox(text, title, icon);
                msgbox.ShowDialog();
            }
            else if (type == "YesNoCancle")
            {
                msgbox = new MessageBoxs.YesNoCancle_MessageBox(text, title, icon);
                msgbox.ShowDialog();
            }
            else if (type == "YesNo")
            {
                msgbox = new MessageBoxs.YesNo_MessageBox(text, title, icon);
                msgbox.ShowDialog();
            }
            else
            {
                msgbox = new Pop_up_windows.BSOD(":(", "作業系統接收到無效的請求，如果" +
                    "您是程式開發人員，請檢察程式碼。\n正在收集錯誤資訊...", "INVALID_REQUEST");
                msgbox.ShowDialog();
            }
            return msgbox.DialogResult;
        }
        public static async void show_notify(string title, string text, int close, string type, bool foucs)
        {
            titles.Add(title);
            texts.Add(text);
            closes.Add(close);
            types.Add(type);
            foucses.Add(foucs);
            if (notify_show == false)
            {
                show();
            }
        }

        public static void next_notify()
        {
            notify_show = false;
            titles.RemoveAt(0);
            texts.RemoveAt(0);
            closes.RemoveAt(0);
            types.RemoveAt(0);
            foucses.RemoveAt(0);
            if (foucses.Count > 0)
            {
                show();
            }
        }

        private async static void show()
        {
            var notify =
                new MessageBoxs.Notify_normal(titles[0], texts[0], closes[0], types[0], 1);
            notify_show = true;
            if (foucses[0] == true)
            {
                notify.ShowDialog();
            }
            else
            {
                notify.Show();
            }
        }
    }
}