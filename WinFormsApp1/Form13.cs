using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void change_font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            DialogResult result =
                fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Picker.Font = fontDialog1.Font;
            }
        }

        private void Reset_font_Click(object sender, EventArgs e)
        {
            Picker.Font = new Font("Poppins", 20, style: FontStyle.Bold);
        }

        List<int> already_picked = new List<int>();
        private async void PICK_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Picking_sound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            int change_speed = 600;
            int rdn;
            int T = (int)To.Value;
            int F = (int)From.Value;
            int choose_value = 0;
            for (; change_speed > 1; change_speed -= 10)
            {
                choose_value = (rdn = new Random().Next(F, T));
                Picker.Text = choose_value.ToString();
                await Task.Delay((int)change_speed / 10);
            } 
            if (repeat_choose.Checked == false && already_picked.Contains(choose_value)) 
            {
                if (already_picked.Count >= (T - F) + 1)
                {
                    Program.show_msgbox("重複選擇",
                        "所有在選擇範圍內的數字都已被選擇，已重新開始。",
                        "Info", "OK");
                    already_picked.Clear();
                }
            } else
            {
                choose_value = (rdn = new Random().Next(F, T));
                while (already_picked.Contains(choose_value))
                {
                    choose_value = (rdn = new Random().Next(F, T));
                    Picker.Text = choose_value.ToString();
                }
            }
            already_picked.Add(choose_value);
        }

        private void From_ValueChanged(object sender, EventArgs e)
        {
            To.Minimum = (int)From.Value + 1;
        }

        private void To_ValueChanged(object sender, EventArgs e)
        {
            From.Maximum = (int)To.Value - 1;
        }
    }
}
