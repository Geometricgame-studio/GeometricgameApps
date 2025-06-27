using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace All_tools_Form_Apps
{
    public partial class shutdown_app : Form
    {
        string mode = "";
        int shutdown_delay = 0;
        int shutdown_time_delay = 0;
        public shutdown_app(string shutdown_mode, int delay, int shutdown_time)
        {
            InitializeComponent();

            mode = shutdown_mode;
            shutdown_delay = delay;
            shutdown_time_delay = shutdown_time;
        }

        private async void shutdown_app_Load(object sender, EventArgs e)
        {
            await Task.Delay(shutdown_delay);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pgs_run();

            if (mode == "restart" || mode == "restart_opt")
            {
                label1.Text = "正在重新啟動";
            }
            else if (mode == "shutdown")
            {
                label1.Text = "正在關機";
            }

            int rdn;
            await Task.Delay(shutdown_time_delay * 1000);

            if (mode == "shutdown")
            {
                this.Close();
            }
            else if (mode == "restart")
            {
                Application.Restart();
                System.Environment.Exit(System.Environment.ExitCode);
            }
            else
            {
                Directory.CreateDirectory("C:\\GeometricgamesApps\\startup");
                File.Create("C:\\GeometricgamesApps\\startup\\opt_mode.gsi");

                Application.Restart();
                System.Environment.Exit(System.Environment.ExitCode);
            }
        }

        Boolean error = false;
        private async void pgs_run()
        {
            await Task.Delay(5);
            progressBar1.Size = new Size(this.Width, 27);
            while (error == false)
            {
                progressBar1.Value = 0;
                progressBar1.ChannelColor = Color.Black;
                progressBar1.SliderColor = Color.SkyBlue;
                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Value += 10;
                    await Task.Delay(1);
                }

                progressBar1.Value = 0;
                progressBar1.ChannelColor = Color.SkyBlue;
                progressBar1.SliderColor = Color.Black;
                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Value += 10;
                    await Task.Delay(1);
                }
            }
        }

        private async void run_failed()
        {
            error = true;
            await Task.Delay(10);
            progressBar1.Value = 0;
            progressBar1.ChannelColor = Color.Red;
            label1.Visible = false;
            progressBar1.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("系統沒有以正常方式關閉，您所有未儲存的變更將會遺失!\n" +
                "如有不便，敬請見諒!",
                "系統意外關閉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
