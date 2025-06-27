using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace All_tools_Form_Apps
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtdownloadplace.Text == "")
            {
                Program.show_msgbox("下載無法開始", "您必須選擇要將檔案下載哪裡。", "Error", "OK");
            }
            else if (txturl.Text == "")
            {
                Program.show_msgbox("下載無法開始", "您必須填寫要下載的影片的連結(URL)", "Error", "OK");
            }
            else
            {
                Download();
            }
        }

        private void Download()
        {
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txturl.Text);
            VideoInfo vi = videos.First(info => info.VideoType == VideoType.Mp4 &&
            info.Resolution == Convert.ToInt32(360));

            if (vi.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(vi);
            }

            if (txtdownloadname.Text == "")
            {
                var videodownload = new VideoDownloader(vi, txtdownloadplace.Text + vi.Title + vi.VideoExtension);
                videodownload.DownloadFinished += Videodownload_DownloadFinished;
            }
            else
            {
                var videodownload = new VideoDownloader(vi, txtdownloadplace.Text + txtdownloadname.Text);
                videodownload.DownloadFinished += Videodownload_DownloadFinished;
            }
        }

        private void Videodownload_DownloadFinished(object s, EventArgs e)
        {
            Program.show_msgbox("影片下載完成!", "影片已成功下載!", "Info", "OK");
        }

        private void browsefile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtdownloadplace.Text = fbd.SelectedPath;
            }
        }
    }
}
