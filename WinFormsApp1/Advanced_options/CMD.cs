using All_tools_Form_Apps.Games.Bomp_game;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Net.Mime.MediaTypeNames;

namespace All_tools_Form_Apps.Advanced_options
{
    public partial class CMD : Form
    {
        int cannotchangetexts = 0;
        string cannotchangetext = "";
        public CMD()
        {
            InitializeComponent();

            cmdtxt.Text = "Geometricgame Studio Commmand Prompt\n" +
                "<*C.BlazeOS.Geometricgame.Apps.Folder>";
            cannotchangetexts = cmdtxt.Text.Length;
            cannotchangetext = cmdtxt.Text;
            cmdtxt.SelectionStart = cmdtxt.Text.Length;

            review_cmd_num = entered_commands.Count;
        }

        int review_cmd_num;

        private void cmdtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (pausing == false)
            {
                if (cmdtxt.SelectionStart < cannotchangetexts)
                {
                    cmdtxt.SelectionStart = cannotchangetexts;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    runcommand(cmdtxt.Text.Substring(cannotchangetexts,
                        cmdtxt.Text.Length - cannotchangetexts));
                }
                if (e.KeyCode == Keys.Up)
                {
                    e.Handled = true;
                    if (review_cmd_num < entered_commands.Count - 1)
                    {
                        review_cmd_num++;
                        cmdtxt.Text = cannotchangetext + entered_commands
                            [entered_commands.Count - review_cmd_num - 1];
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    e.Handled = true;
                    if (review_cmd_num > 1)
                    {
                        review_cmd_num--;
                        cmdtxt.Text = cannotchangetext + entered_commands
                            [entered_commands.Count - review_cmd_num];
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (cmdtxt.Text.Length - 1 < cannotchangetexts)
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (waiting)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
                pausing = false;
            }
        }

        List<string> entered_commands = new List<string>();
        Boolean start_crashing = false;

        private async void runcommand(string command)
        {

            if (anser)
            {
                command = entered_commands[entered_commands.Count - 1] +
                    " " + command;
            }

            if (command.Length < 256)
            {
                List<string> all_cmds = new List<string>();
                List<string> cmd_parameters = new List<string>(command.Split(" ").ToList());
                all_cmds = ["exit", "help", "echo", "shutdown", "cscore", "skippsw",
                "ver", "clear", "path", "cmd", "title", "date", "set", "dir",
                    "vmplayer", "crash"];
                if (command != "")
                {
                    entered_commands.Add(command);
                }

                command = cmd_parameters[0];
                if (all_cmds.Contains(command) || anser == true)
                {
                    if (command == "exit")
                    {
                        this.Close();
                    }
                    else if (command == "help")
                    {
                        if (cmd_parameters.Count < 2)
                        {
                            print("ALL COMMANDS:\n" +
                                "   exit - Exit Commmand Prompt\n" +
                                "   help - Get help\n" +
                                "   ver - Get Command Prompt version\n" +
                                "   echo - Print text you entered\n" +
                                "   shutdown - shutdown Geometricgame Apps\n" +
                                "   cscore - Go to score system\n" +
                                "   skippsw - Open the system without password\n" +
                                "   clear - Clear all texts in command prompt\n" +
                                "   path - Get folder path you select\n" +
                                "   cmd - Run command in Windows Command Prompt\n" +
                                "   title - Change the title of this command prompt\n" +
                                "   date - Show Datatime\n" +
                                "   set - Change settings of this command prompt\n" +
                                "   dir - Show all file(s) in selected folder\n" +
                                "   vmplayer - Open VideoMediaPlayer");
                        }
                        else
                        {
                            if (all_cmds.Contains(command))
                            {
                                if (cmd_parameters[1] == "exit")
                                {
                                    print("Exit Command Prompt\n\n" +
                                        "EXIT");
                                }
                                else if (cmd_parameters[1] == "ver")
                                {
                                    print("Get version of this command prompt\n\n" +
                                        "VER");
                                }
                                else if (cmd_parameters[1] == "echo")
                                {
                                    print("Echo the word(s) you entered\n\n" +
                                            "ECHO [text]");
                                }
                                else if (cmd_parameters[1] == "shutdown")
                                {
                                    print("Shutdown Geometricgame Apps\n\n" +
                                            "SHUTDOWN");
                                }
                                else if (cmd_parameters[1] == "clear")
                                {
                                    print("Clear all texts in this command prompt\n\n" +
                                        "CLEAR");
                                }
                                else if (cmd_parameters[1] == "title")
                                {
                                    print("Set the title of this command prompt\n\n" +
                                            "TITLE [text]");
                                }
                                else if (cmd_parameters[1] == "set")
                                {
                                    print("Change settings of this command prompt\n\n" +
                                            "SET [setting] [value]");
                                }
                                else if (cmd_parameters[1] == "dir")
                                {
                                    print("List all file(s) in folder you selected\n\n" +
                                        "DIR {folder path}");
                                }
                                else
                                {
                                    print("Command " + cmd_parameters[1] + " exist, but cannot find help of that command.");
                                }
                            }
                            else
                            {
                                print("Command Not Found, Type >help< to get help.");
                            }
                        }
                    }
                    else if (command == "ver")
                    {
                        print("Geometricgame Command Prompt 1.1.0");
                    }
                    else if (command == "echo")
                    {
                        if (cmd_parameters.Count > 1)
                        {
                            print(cmd_parameters[1]);
                        }
                        else
                        {
                            print("Parameters are missing or entered incorrectly.");
                        }
                    }
                    else if (command == "shutdown")
                    {
                        if (anser == false)
                        {
                            ask("Are you sure to shutdown Geometricgame Apps? (Y/N) ");
                        }
                        else
                        {
                            anser = false;
                            if (cmd_parameters[1] == "Y")
                            {
                                System.Environment.Exit(System.Environment.ExitCode);
                            }
                            else
                            {
                                print("");
                            }
                        }

                    }
                    else if (command == "clear")
                    {
                        clear_cmdtxt();
                    }
                    else if (command == "cscore")
                    {
                        new All_tools_Form_Apps.Pop_up_windows.Cattest_password().Show();
                        print("Open cscore system sucessfully!");
                    }
                    else if (command == "skippsw")
                    {
                        print("Please go to 進階選項 page and press 以未登入的方式進入系統 button.");
                    }
                    else if (command == "path")
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog();
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            print("Select Path is: " + dialog.SelectedPath);
                        }
                        else
                        {
                            print("Failed to get folder path.");
                        }
                    }
                    else if (command == "cmd")
                    {
                        if (anser == false)
                        {
                            ask("Please enter Windows command prompt command: ");
                        }
                        else
                        {
                            anser = false;
                            if (cmd_parameters[1] != "")
                            {
                                Process.Start("CMD.exe", "/C" + cmd_parameters[1]);
                                print("");
                            }
                            else
                            {
                                print("Command cannot be empty.");
                            }
                        }
                    }
                    else if (command == "title")
                    {
                        if (cmd_parameters.Count > 1)
                        {
                            this.Text = cmd_parameters[1];
                            print("Command prompt title set to: " + cmd_parameters[1]);
                        }
                        else
                        {
                            print("Parameters are missing or entered incorrectly.");
                        }
                    }
                    else if (command == "date")
                    {
                        print("Time Now is: " + DateTime.Now);
                    }
                    else if (command == "set")
                    {
                        if (cmd_parameters.Count > 1)
                        {
                            if (cmd_parameters[1] == "font")
                            {
                                if (cmd_parameters.Count > 2)
                                {
                                    if (cmd_parameters[2] == "change")
                                    {
                                        if (anser == false)
                                        {
                                            ask("Are you sure to change font? maybe will make some bugs! (Y/N) ");
                                        }
                                        else
                                        {
                                            anser = false;
                                            if (cmd_parameters[3] == "Y")
                                            {
                                                FontDialog fontDialog = new FontDialog();
                                                if (fontDialog.ShowDialog() == DialogResult.OK)
                                                {
                                                    cmdtxt.Font = fontDialog.Font;
                                                    print("Command Prompt font set to: " + fontDialog.Font);
                                                }
                                                else
                                                {
                                                    print("Failed to change Font.");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        cmdtxt.Font = new System.Drawing.Font("Cascadia Mono", 14, FontStyle.Regular);
                                        print("Font Reset!");
                                    }
                                }
                                else
                                {
                                    print("You most enter 'change' or 'reset' after 'font' setting.");
                                }
                            }
                            else if (cmd_parameters[1] == "color")
                            {
                                if (cmd_parameters.Count > 2)
                                {
                                    if (cmd_parameters[2] == "change")
                                    {
                                        ColorDialog colorDialog = new ColorDialog();
                                        colorDialog.AnyColor = true;
                                        if (colorDialog.ShowDialog() == DialogResult.OK)
                                        {
                                            cmdtxt.ForeColor = colorDialog.Color;
                                            print("Command Prompt color set to: " + colorDialog.Color);
                                        }
                                        else
                                        {
                                            print("Failed to change Color.");
                                        }
                                    }
                                    else
                                    {
                                        cmdtxt.ForeColor = SystemColors.ScrollBar;
                                        print("Color Reset!");
                                    }
                                }
                                else
                                {
                                    print("You most enter 'change' or 'reset' after 'color' setting.");
                                }
                            }
                            else
                            {
                                print("Unknown setting: " + cmd_parameters[1]);
                            }
                        }
                        else
                        {
                            print("Parameters are missing or entered incorrectly.");
                        }
                    }
                    else if (command == "dir")
                    {
                        if (cmd_parameters.Count > 1)
                        {
                            if (Directory.Exists(cmd_parameters[1]))
                            {
                                print("Files in " + cmd_parameters[1] + ":");
                                repeat_print = true;
                                await Task.Delay(5);

                                print(String.Join("\n", Directory.GetFiles(cmd_parameters[1])));
                                print("There is " + String.Join
                                    ("\n", Directory.GetFiles(cmd_parameters[1]).Length) +
                                    " file(s)\n");

                                repeat_print = false;
                                cmdtxt.SelectionStart = cmdtxt.Text.Length;
                            }
                            else
                            {
                                print("Failed to show dir of: " + cmd_parameters[1] + " path");
                            }
                        }
                        else
                        {
                            FolderBrowserDialog ofd = new FolderBrowserDialog();
                            if (ofd.ShowDialog() == DialogResult.OK)
                            {
                                if (Directory.Exists(ofd.SelectedPath))
                                {
                                    print("Files in " + ofd.SelectedPath + ":");
                                    repeat_print = true;
                                    await Task.Delay(5);

                                    print(String.Join("\n", Directory.GetFiles(ofd.SelectedPath)));
                                    print("There is " + String.Join
                                    ("\n", Directory.GetFiles(ofd.SelectedPath).Length) +
                                    " file(s)\n");

                                    repeat_print = false;
                                    cmdtxt.SelectionStart = cmdtxt.Text.Length;
                                }
                                else
                                {
                                    print("Failed to show dir of: " + ofd.SelectedPath + " path");
                                }
                            }
                        }
                    }
                    else if (command == "vmplayer")
                    {
                        print("Open VideoMediaPlayer successfully!");
                        new Form14().ShowDialog();
                    }
                    else if (command == "crash")
                    {
                        if (anser == false)
                        {
                            ask("This command will crash this app and maybe your computer!\n" +
                                "You cannot stop this command when it already start!\n" +
                                "If your Windows version lower then Windows10, Please don't run this command!\n" +
                                "Continue? (Y/N)");
                        }
                        else
                        {
                            if (cmd_parameters[1] == "Y")
                            {
                                anser = false;

                                if (MessageBox.Show("您確定您知道您在做甚麼嗎?\n" +
                                    "此功能會讓您的Geometricgame Apps崩潰! 甚至是您的裝置!\n" +
                                    "此指令僅為開發人員使用!\n另外，此指令造成的任何損失我們概不負責!\n" +
                                    "請謹慎使用! 此指令在開始後將無法中斷!\n\n要繼續嗎?", "最終警告!",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    MessageBox.Show("若您現在改變心意，您可以使用工作管理員將此程式關閉，即可終止此指令執行!\n" +
                                        "若您不小心開始執行，請立即重新啟動或是登出!\n\n按下 [確定] 以繼續。", "崩潰程式",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    pause();
                                    while (pausing)
                                    {
                                        await Task.Delay(1);
                                    }
                                    wait(5, "Crashing app in 5 seconds");
                                    while (waiting)
                                    {
                                        await Task.Delay(1);
                                    }

                                    for (int i = 0; i < 20; i++)
                                    {
                                        new Thread(crash_thread).Start();
                                    }
                                    start_crashing = true;

                                    while (true)
                                    { }
                                }
                            }
                            else
                            {
                                anser = false;
                            }
                        }
                    }

                    if (anser == false)
                    {
                        if (command != "clear")
                        {
                            print("");
                        }
                    }
                }
                else if (command == "")
                {
                    print("");
                }
                else
                {
                    print("Command: " + command + " Not Found.");
                    print("");
                }
            }
            else
            {
                print("Error, Command too long!");
                print("");
            }
        }

        private async void print(string text)
        {
            cmdtxt_pro_show.Text = cmdtxt.Text;
            cmdtxt_pro_show.SelectionStart = cmdtxt.Text.Length;
            cmdtxt_pro_show.Visible = true;
            if (text == "")
            {
                cmdtxt.Text += "\n";
                cmdtxt.Text += "<*C.BlazeOS.Geometricgame.Apps.Folder>";
            }
            else
            {
                cmdtxt.Text += "\n";
                cmdtxt.Text += text;
            }
            cannotchangetext = cmdtxt.Text;
            cannotchangetexts = cmdtxt.Text.Length;
            cmdtxt.SelectionStart = cmdtxt.Text.Length;
            cmdtxt_pro_show.Visible = false;
        }

        Boolean anser = false;

        private void ask(string text)
        {
            cmdtxt_pro_show.Text = cmdtxt.Text;
            cmdtxt_pro_show.Visible = true;
            cmdtxt.Text += "\n";
            cmdtxt.Text += text;
            cannotchangetext = cmdtxt.Text;
            cannotchangetexts = cmdtxt.Text.Length;
            cmdtxt.SelectionStart = cmdtxt.Text.Length;
            cmdtxt_pro_show.Visible = false;
            anser = true;
        }

        Boolean pausing = false;
        private void pause()
        {
            pausing = true;
            print("Press any key to continue...");
        }

        Boolean waiting = false;
        private async void wait(int sec, string text)
        {
            print(text);
            for (int i = 0; i < sec * 2; i++)
            {
                waiting = true;
                cmdtxt_pro_show.Text = cmdtxt.Text;
                cmdtxt_pro_show.Visible = true;
                cmdtxt.Text += ".";
                cannotchangetext = cmdtxt.Text;
                cannotchangetexts = cmdtxt.Text.Length;
                cmdtxt.SelectionStart = cmdtxt.Text.Length;
                cmdtxt_pro_show.Visible = false;
                await Task.Delay(500);
            }
            waiting = false;
        }

        Boolean repeat_print = false;

        private void clear_cmdtxt()
        {
            cannotchangetexts = 0;
            cmdtxt.Text = "";
            cannotchangetext = cmdtxt.Text;
            cannotchangetexts = cmdtxt.Text.Length;
            cmdtxt.SelectionStart = cmdtxt.Text.Length;
            cmdtxt.Text = "<*C.BlazeOS.Geometricgame.Apps.Folder>";
            cannotchangetext = cmdtxt.Text;
            cannotchangetexts = cmdtxt.Text.Length;
            cmdtxt.SelectionStart = cmdtxt.Text.Length;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            cmdtxt.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            cmdtxt.Paste();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            cmdtxt.Cut();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changefont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                cmdtxt.Font = fontDialog.Font;
            }
        }

        private void reset_font_Click(object sender, EventArgs e)
        {
            cmdtxt.Font = new System.Drawing.Font("Cascadia Mono", 12);
        }

        private void DeleteSelect_Click(object sender, EventArgs e)
        {
            if (cmdtxt.Text.Length < cannotchangetexts)
            {
                cmdtxt.Text = cannotchangetext;
                cmdtxt.SelectionStart = cmdtxt.Text.Length;
            }
            else
            {
                cmdtxt.SelectedText = "";
            }
        }

        private async void crash_thread()
        {
            while (start_crashing == false)
            {
                await Task.Delay(1);
            }
            var test = 0;
            test = 0;

            for (int i = 0; i < 999; i++)
            {
                test++;

                Process p = new Process();
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "msg * /time 1 " + test.ToString();
                p.StartInfo.FileName = "cmd.exe";
                p.Start();

                await Task.Delay(100);
            }
        }
    }
}
