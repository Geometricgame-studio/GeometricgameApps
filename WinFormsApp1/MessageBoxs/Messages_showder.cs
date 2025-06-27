using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.MessageBoxs
{
    public partial class Messages_showder : Form
    {
        public Messages_showder()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void Messages_showder_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        string result = "";

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;

            Directory.CreateDirectory(@"C:\GeometricgamesApps\using");
            if (File.Exists(@"C:\GeometricgamesApps\using\message.txt"))
            {
                File.Delete(@"C:\GeometricgamesApps\using\message.txt");
            }

            using (var client = new HttpClient())
            {
                using (var s = client.GetStreamAsync("https://freegeometricgames.com/messages.txt"))
                {
                    using (var fs = new FileStream(@"C:\GeometricgamesApps\using\message.txt", FileMode.OpenOrCreate))
                    {
                        try
                        {
                            s.Result.CopyTo(fs);
                        }
                        catch (AggregateException ex)
                        {
                            Program.show_errors(ex, "無法載入廣播訊息", "請確保您已連線至網際網路!");
                        }
                    }
                }

                using (StreamReader sr = new StreamReader(@"C:\GeometricgamesApps\using\message.txt"))
                {
                    result = sr.ReadToEnd();
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void disable_forever_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您確定您不想再收到廣播訊息嗎?\n這項操作可以透過編輯檔案來復原。", "取消訂閱", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.Create(@"C:\GeometricgamesApps\using\cancel_message.gos");

                this.Close();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            conten.Text = result;
        }
    }
}
