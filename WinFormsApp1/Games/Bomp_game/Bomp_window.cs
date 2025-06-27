using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.Games.Bomp_game
{
    public partial class Bomp_window : Form
    {
        int rdn = 0;
        int scn_width = Screen.PrimaryScreen.Bounds.Width;
        int scn_height = Screen.PrimaryScreen.WorkingArea.Height;
        public Bomp_window()
        {
            InitializeComponent();
            this.TopMost = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Bomp_window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                fall_px = -100;
            }
        }
        int msfar_X;
        int msfar_Y;
        int fall_px = 0;
        private async void Bomp_window_Load(object sender, EventArgs e)
        {
            this.Location = new Point
                ((rdn = new Random().Next(0, scn_width)),
                (rdn = new Random().Next(0, scn_height)));
            double move_px = 0;

            while (true)
            {
                msfar_X = MousePosition.X - (this.Location.X + (this.Width / 2));
                msfar_Y = (this.Location.Y + (this.Height / 2)) - MousePosition.Y;
                if (this.Location.Y > (scn_height - this.Height))
                {
                    fall_px = -50;
                    for (int i = 0; fall_px < 1; i++)
                    {
                        msfar_X = MousePosition.X - (this.Location.X + (this.Width / 2));
                        msfar_Y = (this.Location.Y + (this.Height / 2)) - MousePosition.Y;

                        this.Location = new Point(this.Location.X,
                            this.Location.Y + (fall_px / 5));
                        await Task.Delay(10);
                        fall_px++;

                        if (msfar_X > -200 && msfar_X < 0 && msfar_Y < 200)
                        {
                            move_px += 5;
                            //this.Location = new Point(this.Location.X + 5, this.Location.Y);
                        }
                        if (msfar_X > 0 && msfar_X < 200 && msfar_Y < 200)
                        {
                            move_px -= 5;
                            //this.Location = new Point(this.Location.X - 5, this.Location.Y);
                        }
                        this.Location = new Point(this.Location.X + (int)move_px, this.Location.Y);
                        move_px = move_px * 0.8;
                        if (this.Location.Y < 0)
                        {
                            fall_px = 50;
                            this.Location = new Point(this.Location.X, 5);
                        }
                    }
                }
                else
                {
                    this.Location = new Point(this.Location.X,
                        this.Location.Y + (fall_px / 5));
                    fall_px++;
                    if (this.Location.Y < 0)
                    {
                        fall_px = 50;
                        this.Location = new Point(this.Location.X, 5);
                    }
                }

                if (msfar_X > -250 && msfar_X < 0 && msfar_Y < 250)
                {
                    move_px += 5;
                    //this.Location = new Point(this.Location.X + 5, this.Location.Y);
                }
                if (msfar_X > 0 && msfar_X < 250 && msfar_Y < 250)
                {
                    move_px -= 5;
                    //this.Location = new Point(this.Location.X - 5, this.Location.Y);
                }
                this.Location = new Point(this.Location.X + (int)move_px, this.Location.Y);
                move_px = move_px * 0.8;

                await Task.Delay(10);

                if (this.Location.X > scn_width || this.Location.X < -100)
                {
                    this.Close();
                }
            }
        }

        private void Bomp_window_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.OrangeRed;
                label1.Text = "UP!";
            }
            else
            {
                this.Close();
            }
        }

        private void Bomp_window_MouseLeave(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.OrangeRed;
                label1.Text = "X";
            }
            else
            {
                this.Close();
            }
        }

        private async void Bomp_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.balls--;
            await Task.Delay(10);
            if (Program.balls < 0)
            {
                MessageBox.Show("ERROR > Bomp_window\nvalue balls can't lower then: 0" +
                    "\nIf you found a technician, give ALL info bellow:\nError code:" +
                    " G1_M0001\nVALUE_CRASH",
                    "Value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
