using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Additioinal_Forms
{
    public partial class Form20_addtional : Form
    {
        string modes = "";
        public Form20_addtional(string mode)
        {
            InitializeComponent();

            modes = mode;

            pictureBox1.Visible = false;
            time.Visible = false;
            btnconfirm.Visible = false;
            txtshowtext.Visible = false;
        }

        private async void Form20_addtional_Load(object sender, EventArgs e)
        {
            if (modes == "showpic")
            {
                await Task.Delay(500);
                openpic();
            }
            else if (modes == "showtime")
            {
                time.Visible = true;
                max_window();
                time.Size = new Size(this.Width, this.Height);

                while (true)
                {

                    string h0 = "";
                    string m0 = "";
                    string s0 = "";
                    string o0 = "";
                    string d0 = "";

                    DateTime dt = DateTime.Now;

                    if (dt.Hour > 12)
                    {
                        if ((dt.Hour - 12).ToString().Length < 2)
                        {
                            h0 = "0";
                        }
                    }
                    else
                    {
                        if (dt.Hour.ToString().Length < 2)
                        {
                            h0 = "0";
                        }
                    }
                    if (dt.Minute.ToString().Length < 2)
                    {
                        m0 = "0";
                    }
                    if (dt.Second.ToString().Length < 2)
                    {
                        s0 = "0";
                    }
                    if (dt.Month.ToString().Length < 2)
                    {
                        o0 = "0";
                    }
                    if (dt.Day.ToString().Length < 2)
                    {
                        d0 = "0";
                    }

                    if (dt.Hour < 12)
                    {
                        time.Text = "上午 " + h0 + dt.Hour + ":" + m0 + dt.Minute + ":" + s0 + dt.Second;
                    }
                    else if (dt.Hour == 12)
                    {
                        time.Text = "中午 " + h0 + dt.Hour + ":" + m0 + dt.Minute + ":" + s0 + dt.Second;
                    }
                    else if (dt.Hour > 12)
                    {
                        time.Text = "下午 " + h0 + ((int)dt.Hour - 12) + ":" + m0 + dt.Minute + ":" + s0 + dt.Second;
                    }

                    time.Text += "\n" + dt.Year + "/" + o0 + dt.Month + "/" + d0 + dt.Day;

                    await Task.Delay(1000);
                }
            }
            else if (modes == "showtext")
            {
                txtshowtext.Visible = true;
                btnconfirm.Visible = true;
            }
            else if (modes == "nothing")
            {
                max_window();
            }
            else
            {
                Program.show_msgbox("操作無效", "指定的操作模式無效!", "Error", "OK");

                this.Close();
            }
        }

        private void openpic()
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "center";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "請選擇一個圖片";
            ofd.Filter = "圖片檔案|*.png;*.svg;*.jpg;*.jpeg;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    max_window();
                    pictureBox1.Size = new System.Drawing.Size(this.Width, this.Height);
                }
                catch (OutOfMemoryException)
                {
                    Program.show_msgbox("資源不足", "您所指定的圖片佔用太多資源，請重新選取圖片。" +
                        "\n如果此現象重複發生，您可以重新啟動電腦或本應用程式，也可以試著選擇另一張圖片。", "Error", "OK");
                    openpic();
                }
            }
            else
            {
                openpic();
            }
        }

        private void max_window()
        {
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            max_window();

            txtshowtext.Visible = false;
            btnconfirm.Visible = false;
            time.Visible = true;
            time.Text = txtshowtext.Text;
            time.Size = new Size(this.Width, this.Height);
        }

        private void Form20_addtional_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor.Show();
        }
    }
}
