using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace All_tools_Form_Apps
{
    public partial class Form14 : Form
    {

        List<string> filterFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;
        public Form14()
        {
            InitializeComponent();

            ellipseContorl1.CornerRadius = 25;
            exit_fullscreen.Visible = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1492, 659);
            VideoPlayer.Size = new Size(946, 519);
            full_screen = false;
        }

        private void SelectFolder()
        {
            VideoPlayer.Ctlcontrols.stop();

            if (filterFiles.Count > 1)
            {
                filterFiles.Clear();
                filterFiles = null;
                PlayList.Items.Clear();
                currentFile = 0;
            }

            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                filterFiles = Directory.GetFiles(browser.SelectedPath, "*.*")
                    .Where(file => file.ToLower().EndsWith("avi") ||
                    file.ToLower().EndsWith("mp4") ||
                    file.ToLower().EndsWith("wmv") ||
                    file.ToLower().EndsWith("mkv") ||
                    file.ToLower().EndsWith("mp3") ||
                    file.ToLower().EndsWith("wav")).ToList();

                LoadPlayList();
            }
        }

        private void ShowAbout_Click(object sender, EventArgs e)
        {

        }

        private void VideoPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                lblDuration.Text = "準備就緒!";
            }
            else if (e.newState == 1)
            {
                lblDuration.Text = "中斷播放";
                stop.Enabled = false;
            }
            else if (e.newState == 3)
            {
                lblDuration.Text = "時長: " + VideoPlayer.currentMedia.durationString;
                stop.Enabled = true;
            }
            else if (e.newState == 8)
            {
                if (currentFile >= filterFiles.Count - 1)
                {
                    currentFile = 0;
                }
                else
                {
                    currentFile++;
                }

                PlayList.SelectedIndex = currentFile;
                ShowFileName(fileName);
            }
            else if (e.newState == 9)
            {
                lblDuration.Text = "正在載入檔案...";
            }
            else if (e.newState == 10)
            {
                timer1.Start();
            }
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFile = PlayList.SelectedIndex;
            PlayFile(PlayList.SelectedItem.ToString());
            ShowFileName(fileName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VideoPlayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LoadPlayList()
        {
            VideoPlayer.currentPlaylist = VideoPlayer.newPlaylist("PlayList", "");

            foreach (string videos in filterFiles)
            {
                VideoPlayer.currentPlaylist.appendItem(VideoPlayer.newMedia(videos));
                PlayList.Items.Add(videos);
            }

            if (filterFiles.Count > 0)
            {
                Program.show_notify("媒體播放器", filterFiles.Count + " 個檔案匯入成功!",
                    1000, "done", false);
                fileName.Text = "在 " + Path.GetFileName(browser.SelectedPath) + "中找到 "
                    + filterFiles.Count + " 個可播放的檔案。";
                PlayList.SelectedIndex = currentFile;
                PlayFile(PlayList.SelectedItems.ToString());
            }
            else
            {
                Program.show_notify("媒體播放器", Path.GetFileName(browser.SelectedPath) +
                    " 中沒有可播放的檔案。", 2500, "error", false);
            }
        }

        private void PlayFile(string url)
        {
            VideoPlayer.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(PlayList.SelectedItem.ToString());
            name.Text = "正在播放: " + file;
        }

        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoPlayer.Ctlcontrols.stop();
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (pause.Text == "⏸️")
            {
                VideoPlayer.Ctlcontrols.pause();
                pause.Text = "▶️";
            }
            else
            {
                VideoPlayer.Ctlcontrols.play();
                pause.Text = "⏸️";
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            VideoPlayer.Ctlcontrols.stop();
        }


        Boolean full_screen = false;
        private async void fullscreen_Click(object sender, EventArgs e)
        {
            ellipseContorl1.CornerRadius = 0;
            exit_fullscreen.Visible = true;
            this.FormBorderStyle = FormBorderStyle.None;
            full_screen = true;
            this.WindowState = FormWindowState.Maximized;
            exit_fullscreen.Location = new Point(0, this.Height - 35);
            exit_fullscreen.Size = new Size(this.Width, 35);
            VideoPlayer.Size = new Size(this.Width, this.Height);
            Boolean can_exit_fullscreen = false;

            Point mouse_beforepos = MousePosition;
            while (full_screen)
            {
                if (MousePosition != mouse_beforepos)
                {
                    mouse_beforepos = MousePosition;
                    exit_fullscreen.Visible = true;
                    
                    if (can_exit_fullscreen == false)
                    {
                        exit_fullscreen.Location = new Point(0, this.Height);
                        for (int y = 0; y < 34; y += 2)
                        {
                            exit_fullscreen.Location = new Point(0, this.Height - y);
                            await Task.Delay(1);
                        }
                        can_exit_fullscreen = true;
                    }

                    await Task.Delay(2500);
                }
                else
                {
                    for (int y = 0; y < 34; y += 2)
                    {
                        exit_fullscreen.Location = new Point(0, (this.Height - 35) + y);
                        await Task.Delay(1);
                    }
                    can_exit_fullscreen = false;

                    exit_fullscreen.Visible = false;
                }
                await Task.Delay(1);
            }
        }

        private void exit_fullscreen_Click(object sender, EventArgs e)
        {
            ellipseContorl1.CornerRadius = 25;
            exit_fullscreen.Visible = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1492, 659);
            VideoPlayer.Size = new Size(946, 519);
            full_screen = false;
        }
    }
}
