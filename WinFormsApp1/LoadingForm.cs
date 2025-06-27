using All_tools_Form_Apps.Custom_class;
using IWshRuntimeLibrary;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace All_tools_Form_Apps
{
    public partial class LoadingForm : Form
    {
        List<string> text_list = new List<string>();
        Boolean loading = true;

        public LoadingForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            complete.Text = "0%";
            this.CenterToScreen();
            this.Opacity = 0;
            this.TopMost = true;
            progressBar1.Visible = false;
            complete.Visible = false;
            label1.Text = "Welcome!";
            label2.Visible = false;

            vertion.Text = "Geometricgames " + Program.version;

            text_list.Add("Welcome to our HAPPY LAND!");
            text_list.Add("Play all the games for FREE!");
            text_list.Add("Starting up...");
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            var menu = new Form();
            if (System.IO.File.Exists(@"C:\GeometricgamesApps\using\stay_login.gss"))
            {
                menu = Program.main_forms;
            }
            else
            {
                menu = new Login_System_login();
            }

            for (int opacity = 90; opacity > 0; opacity--)
            {
                this.Opacity += 0.01;
                await Task.Delay(1);
            }
            Text_Change();
            await Task.Delay(100);
            int rdn = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            complete.Visible = true;

            //checking startup setting and infos
            if (System.IO.File.Exists("C:\\GeometricgamesApps\\startup\\opt_mode.gsi"))
            {
                label1.Text = "Start up setting redirect opations...";
                System.IO.File.Delete("C:\\GeometricgamesApps\\startup\\opt_mode.gsi");
                this.Hide();
                new All_tools_Form_Apps.Advanced_options.Main_form().ShowDialog();
                this.Close();
            }

            label1.Text = "Initializing data...";

            //Initializing app_setting
            if (System.IO.File.Exists(@"C:\GeometricgamesApps\using\App_onoff_settings.gss"))
            {
                StreamReader sr = new StreamReader(@"C:\GeometricgamesApps\using\App_onoff_settings.gss");
                Task<string> text = sr.ReadToEndAsync();
                List<string> app_onoff_setting_value = new List<string>(text.Result.Split(",").ToList());
                List<bool> app_onoff_setting_values = new List<bool>();
                for (int i = 0; i < app_onoff_setting_value.Count; i++)
                {
                    try
                    {
                        app_onoff_setting_values.Add(bool.Parse(app_onoff_setting_value[i]));
                    }
                    catch (Exception ex)
                    {
                        sr.Close();

                        DialogResult result =
                        MessageBox.Show("初始化失敗!\n" +
                            "由於初始化必需的數值被其他的應用程式或人為更動，因此無法成功完成初始化動作。\n" +
                            "系統正在自動修復初始化檔案，要啟動自動修復嗎?\n\n" +
                            "系統錯誤回報如下:\n" + ex + "\n====================\n" +
                            "按下 [是] 啟動自動修復\n按下 [否] 嘗試繼續執行程式", "初始化失敗",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (result == DialogResult.Yes)
                        {
                            string filename = "App_onoff_settings.gss";
                            string folderPath = @"C:\GeometricgamesApps\using\";
                            string contens = ""
                                + Program.lasttool_ok + ","
                                + Program.shutdown_ok + ","
                                + Program.open_clicker_ok + ","
                                + Program.computeer_ok + ","
                                + Program.send_email_ok + ","
                                + Program.alarm_ok + ","
                                + Program.clock_ok + ","
                                + Program.games_ok + ","
                                + Program.media_player_ok + ","
                                + Program.youtube_downloader_ok + ","
                                + Program.number_picker_ok + ","
                                + Program.browser_ok + ","
                                + Program.notepad_ok;
                            Directory.CreateDirectory(folderPath);

                            using (StreamWriter sw = new StreamWriter(folderPath + filename))
                            {
                                sw.WriteLineAsync(contens);
                                MessageBox.Show("自動修復:\n" +
                                    "已成功修復檔案，請再次重新啟動以正常執行。"
                                    , "檔案修復成功!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                System.Windows.Forms.Application.Restart();
                            }
                        }
                    }
                }
                try
                {
                    Program.lasttool_ok = app_onoff_setting_values[0];
                    Program.shutdown_ok = app_onoff_setting_values[1];
                    Program.open_clicker_ok = app_onoff_setting_values[2];
                    Program.computeer_ok = app_onoff_setting_values[3];
                    Program.send_email_ok = app_onoff_setting_values[4];
                    Program.alarm_ok = app_onoff_setting_values[5];
                    Program.clock_ok = app_onoff_setting_values[6];
                    Program.games_ok = app_onoff_setting_values[7];
                    Program.media_player_ok = app_onoff_setting_values[8];
                    Program.youtube_downloader_ok = app_onoff_setting_values[9];
                    Program.number_picker_ok = app_onoff_setting_values[10];
                    Program.browser_ok = app_onoff_setting_values[11];
                    Program.notepad_ok = app_onoff_setting_values[12];
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("初始化失敗!\n" +
                        "初始化所需的數值數量不足，無法全部完成初始化動作，請檢察您的初始化檔案並修正。\n\n" +
                        "系統錯誤回報如下:\n" + ex + "\n====================\n" +
                        "按下 [確定] 以關閉程式"
                        , "初始化失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(Environment.ExitCode);
                }
            }

            //Checking for update info
            label1.Text = "Checking for Updates...";
            label2.Text = "Please wait for a seconds...";

            await Task.Delay(500);

            if (System.IO.File.Exists("C:\\GeometricgamesApps\\using\\version_info.gsf"))
            {
                string version_number = "";

                using (StreamReader sr = new StreamReader("C:\\GeometricgamesApps\\using\\version_info.gsf"))
                {
                    version_number = sr.ReadLineAsync().Result;
                }

                if (version_number != Program.version)
                {
                    this.Hide();
                    new update_conten_info().ShowDialog();
                    System.Windows.Forms.Application.Restart();
                    this.Close();
                }
            }

            //No code {} local buffer
            {
                Boolean check_s = true;
                string result = "";

                using (var client = new HttpClient())
                {
                    using (var s = client.GetStreamAsync("https://freegeometricgames.com/last_version.txt"))
                    {
                        using (var fs = new FileStream(@"C:\GeometricgamesApps\using\last_version.gsf", FileMode.OpenOrCreate))
                        {
                            try
                            {
                                s.Result.CopyTo(fs);
                            }
                            catch (Exception ex)
                            {
                                label2.Text = "Checking Failed!";
                                label1.Text = "Skipping this check in 3 seconds...";
                                await Task.Delay(3000);
                                check_s = false;
                            }
                        }
                    }

                    if (check_s)
                    {
                        System.IO.File.Delete(@"C:\GeometricgamesApps\using\last_version.txt");
                        using (StreamReader sr = new StreamReader(@"C:\GeometricgamesApps\using\last_version.gsf"))
                        {
                            result = sr.ReadLineAsync().Result;
                        }
                    }

                    if (result != Program.version && check_s)
                    {
                        this.Hide();
                        new All_tools_Form_Apps.MessageBoxs.Update_confirm().ShowDialog();
                        this.Show();
                    }
                }
            }

                loading = true;
            for (int i = 0; progressBar1.Value < 100; i++)
            {
                complete.Text = (progressBar1.Value).ToString() + "%";
                progressBar1.Value += 1;
                await Task.Delay(rdn = new Random().Next(0, 1));
            }

            label1.Text = "Creating datas...";

            //creating shortcut
            string folder_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            creating_shortcut(folder_path);
            //
            //creating version info
            Directory.CreateDirectory("C:\\GeometricgamesApps\\using");

            using (StreamWriter sw = new StreamWriter("C:\\GeometricgamesApps\\using\\version_info.gsf"))
            {
                sw.WriteLineAsync(Program.version);
            }
            //

            progressBar1.Value = 0;
            for (int i = 0; progressBar1.Value < 100; i++)
            {
                complete.Text = (progressBar1.Value).ToString() + "%";
                progressBar1.Value += 1;
                await Task.Delay(rdn = new Random().Next(0, 1));
            }
            label1.Text = "Checking user windows version...";
            progressBar1.Value = 0;
            for (int i = 0; progressBar1.Value < 100; i++)
            {
                complete.Text = (progressBar1.Value).ToString() + "%";
                progressBar1.Value += 1;
                await Task.Delay(rdn = new Random().Next(0, 1));
            }

            label1.Text = "Setting up...";
            progressBar1.Value = 0;
            for (int i = 0; progressBar1.Value < 100; i++)
            {
                complete.Text = (progressBar1.Value).ToString() + "%";
                progressBar1.Value += 1;
                await Task.Delay(rdn = new Random().Next(0, 10));
            }

            loading = false;

            this.Hide();
            if (clicked < 5)
            {
                menu.ShowDialog();
            }
            else if (clicked > 5 && clicked < 10)
            {
                throw new BallFishException();
            }
            else
            {
                new All_tools_Form_Apps.Advanced_options.Main_form().ShowDialog();
            }

            this.Show();
            label1.Text = "Thanks for using!";
            complete.Text = "";
            progressBar1.Visible = false;
            await Task.Delay(1000);
            for (int opacity = 90; opacity > 0; opacity--)
            {
                this.Opacity -= 0.01;
                await Task.Delay(1);
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Text_Change()
        {
            label2.Visible = true;
            while (loading == true)
            {
                label2.Text = text_list[new Random().Next(0, text_list.Count)];
                await Task.Delay(2500);
            }
            label2.Visible = false;
        }

        int clicked = 0;

        private void LoadingForm_MouseClick(object sender, MouseEventArgs e)
        {
            clicked++;
            if (clicked > 4)
            {
                label1.Text = "Startup for Advanced options";
            }
        }

        private void Form_is_click(object sender, EventArgs e)
        {
            clicked++;
            if (clicked > 4)
            {
                label1.Text = "Startup for Advanced options";
            }
        }

        private void creating_shortcut(string saveDir)
        {
            try
            {
                List<string> Path = System.Windows.Forms.Application.ExecutablePath.Split('\\').ToList();
                string icon_path = "";
                for (int i = 0; i < Path.Count - 1; i++)
                {
                    icon_path = icon_path + Path[i] + "\\";
                }
                if (System.IO.File.Exists(icon_path + "\\icon.ico") == false)
                {
                    System.IO.File.Copy(icon_path + "\\icon.ico", "C:\\GeometricgamesApps\\using\\icon.ico");
                }
                WshShell wshShell = new WshShell();
                string fileName = saveDir + "\\" + ProductName + ".lnk";
                IWshShortcut shortcut = (IWshShortcut)wshShell.CreateShortcut(fileName);
                shortcut.TargetPath = System.Windows.Forms.Application.ExecutablePath;
                shortcut.IconLocation = "C:\\GeometricgamesApps\\using\\icon.ico";
                shortcut.Save();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("由於缺少必要的檔案或在建立時發生意外的錯誤，因此無法建立捷徑。\n\n" +
                    "按下 [重試] 將重新啟動程式並再試一次。\n按下 [取消] 則會略過此步驟並進入程式。", "無法建立捷徑"
                    , MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                {
                    System.Windows.Forms.Application.Restart();
                }
            }
        }
    }
}
