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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();

            Program.show_notify("進階計算機", "此功能未完善，為了出現錯誤，已禁用此功能。", 2500, "error", false);
        }

        private void compute_primes_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();

            for (int i = (int)pri_numbers_input1.Value; i < pri_numbers_input2.Value; i++)
            {
                numbers.Add(i);
            }

            for (int i = 2; i < pri_numbers_input2.Value / 2; i++)
            {
                for (int j = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[j] % i == 0)
                    {
                        numbers.Remove(j);
                        MessageBox.Show("");
                    }
                }
            }

            string prime_numbers = "";

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                prime_numbers += numbers[i] + ", ";
            }

            Program.show_msgbox(pri_numbers_input1.Value + " 到 " + pri_numbers_input2.Value + " 的所有質數",
                prime_numbers, "Info", "OK");
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
