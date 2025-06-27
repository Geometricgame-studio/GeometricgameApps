using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.External_res
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void online_search_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "https://freegeometricgames.com/download";
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }

        private void download1_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1_cSCADZlpjRHKc-5RDdl1gn2o54_ai2u&amp;export=download", "bgm_player.exe").ShowDialog();
        }

        private void download2_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=12b9L_T3xPtKDI2RScp89bjgxVAKKdKTC&amp;export=download", "All_tools_Form_Apps_auto_updater.exe").ShowDialog();
        }

        private void download3_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1BilRhCMC-jIdTu7sQxI05fHFjUaUe6Wh&export=download", "Disable Apps.exe").ShowDialog();
        }

        private void download4_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1I11F-xo3QTXejy4889JGMpccvNaJ7NrS&export=download", "timer.exe").ShowDialog();
        }

        private void download5_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1ZJu0JNSr_W_-eqFVbjzFUhvIOpqyXMIy&export=download", "file_explorer.exe").ShowDialog();
        }

        private void download6_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1o-qttAbYSD_WNL2TLGlffgrNg9NiTBIO&export=download", "tomato_clock.exe").ShowDialog();
        }

        private void download7_Click(object sender, EventArgs e)
        {
            new download_choose("https://drive.usercontent.google.com/u/0/uc?id=1SwtIovs5JNNN3OqtZn86BrNIa13HsYa3&export=download", "outlook_sender.exe").ShowDialog();
        }
    }
}
