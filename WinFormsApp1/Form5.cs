using All_tools_Form_Apps.Custom_class;
using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace All_tools_Form_Apps
{

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            number_text = "0";
            number_changed();
        }

        double number = 0;
        string number_text = "";
        List<double> compute_using = new List<double>();
        List<string> compute_duts = new List<string>();
        List<object> compute_all_tokens = new List<object>();
        private void one_Click(object sender, EventArgs e)
        {
            number_text = number_text + "1";
            number_changed();
        }

        private void two_Click(object sender, EventArgs e)
        {
            number_text = number_text + "2";
            number_changed();
        }

        private void three_Click(object sender, EventArgs e)
        {
            number_text = number_text + "3";
            number_changed();
        }

        private void four_Click(object sender, EventArgs e)
        {
            number_text = number_text + "4";
            number_changed();
        }

        private void five_Click(object sender, EventArgs e)
        {
            number_text = number_text + "5";
            number_changed();
        }

        private void six_Click(object sender, EventArgs e)
        {
            number_text = number_text + "6";
            number_changed();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            number_text = number_text + "7";
            number_changed();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            number_text = number_text + "8";
            number_changed();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            number_text = number_text + "9";
            number_changed();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            number_text = number_text + "0";
            number_changed();
        }

        private void zerozero_Click(object sender, EventArgs e)
        {
            number_text = number_text + "00";
            number_changed();
        }

        private void number_changed()
        {
            try
            {
                number = double.Parse(number_text);
                numbers.Text = number.ToString();
                free_input_box.Text = numbers.Text;

                number_path.Text = compute_using[0].ToString();
                for (int i = 0; i < compute_duts.Count; i++)
                {
                    number_path.Text += compute_duts[i] + compute_using[i + 1];
                }
            }
            catch (Exception ex) { }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            number_text = "0";
            number_changed();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            save_number("+");
            pmpm.Text = "+";
        }

        private void minest_Click(object sender, EventArgs e)
        {
            save_number("-");
            pmpm.Text = "-";
        }

        private void plusplus_Click(object sender, EventArgs e)
        {
            save_number("*");
            pmpm.Text = "×";
        }

        private void minminest_Click(object sender, EventArgs e)
        {
            save_number("/");
            pmpm.Text = "÷";
        }

        private void save_number(string compute_dut)
        {
            compute_using.Add(number);
            if (compute_dut != "=")
            {
                compute_duts.Add(compute_dut);
            }
            number_text = "0";
            number_changed();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            compute_numbers();
        }

        private void compute_numbers()
        {
            get_tokens();
            read_and_makingOreo();
            if (success_get_tokens)
            {
                save_number("=");
                pmpm.Text = "計算中...";
                number_path.Text = number_path.Text + "=";
                double result = 0;
                double stop_result = 0;

                try
                {
                    if (compute_duts[0] == "+")
                    {
                        stop_result = compute_using[0] + compute_using[1];
                    }
                    if (compute_duts[0] == "-")
                    {
                        stop_result = compute_using[0] - compute_using[1];
                    }
                    if (compute_duts[0] == "*")
                    {
                        stop_result = compute_using[0] * compute_using[1];
                    }
                    if (compute_duts[0] == "/")
                    {
                        stop_result = compute_using[0] / compute_using[1];
                    }

                    for (int i = 1; i < compute_duts.Count; i++)
                    {
                        if (compute_duts[i] == "+")
                        {
                            stop_result = stop_result + compute_using[i + 1];
                        }
                        if (compute_duts[i] == "-")
                        {
                            stop_result = stop_result - compute_using[i + 1];
                        }
                        if (compute_duts[i] == "*")
                        {
                            stop_result = stop_result * compute_using[i + 1];
                        }
                        if (compute_duts[i] == "/")
                        {
                            stop_result = stop_result / compute_using[i + 1];
                        }
                    }
                }
                catch (Exception ex)
                {
                    stop_result = compute_using[0];
                }

                result = stop_result;
                compute_using.Clear();
                compute_duts.Clear();

                pmpm.Text = "";
                free_input_box.Text = result.ToString();
                free_input_box.Focus();
                free_input_box.SelectionStart = free_input_box.Text.Length;
            }
        }

        private void key_press_num(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                number_text = number_text + "1";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D2)
            {
                number_text = number_text + "2";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D3)
            {
                number_text = number_text + "3";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                number_text = number_text + "4";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                number_text = number_text + "5";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                number_text = number_text + "6";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                number_text = number_text + "7";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D8)
            {
                number_text = number_text + "8";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D9)
            {
                number_text = number_text + "9";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.D0)
            {
                number_text = number_text + "0";
                number_changed();
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                if (number_text.Length > 1)
                {
                    number_text = number_text.Substring(0, number_text.Length - 1);
                    number_changed();
                }
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                compute_numbers();
            }
            if (e.KeyChar == (char)Keys.C)
            {
                number_text = "0";
                number_changed();
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (number_text.Length > 1)
            {
                number_text = number_text.Substring(0, number_text.Length - 1);
                number_changed();
            }
        }

        private void dut_Click(object sender, EventArgs e)
        {
            number_text = number_text + ".";
            number_changed();
        }

        private void number_path_TextChanged(object sender, EventArgs e)
        {
            if (number_path.Text.Length > 32)
            {
                dropdown_paht.Visible = true;
                number_path.Visible = false;
            }
            else
            {
                dropdown_paht.Visible = false;
                number_path.Visible = true;
            }
        }

        private void dropdown_paht_Click(object sender, EventArgs e)
        {
            Program.show_msgbox("完整算式", number_path.Text, "Info", "OK");
        }

        private async void numbers_TextChanged(object sender, EventArgs e)
        {
            if (numbers.Text == "∞")
            {
                compute.Enabled = false;
                while (numbers.Text == "∞")
                {
                    numbers.BackColor = Color.Red;
                    await Task.Delay(500);
                    numbers.BackColor = this.BackColor;
                    await Task.Delay(500);
                }
                compute.Enabled = true;
                numbers.BackColor = this.BackColor;
            }
        }


        Boolean success_get_tokens = false;
        private async void get_tokens()
        {
            if (free_input_box.Text.Length == 0)
            {
                free_input_box.BackColor = Color.Red;
                free_input_box.Text = "Can not be none!";

                while (free_input_box.Text == "Can not be none!")
                {
                    await Task.Delay(5);
                }

                free_input_box.BackColor = SystemColors.Window;
                free_input_box.Text = numbers.Text;
                free_input_box.SelectionStart = free_input_box.Text.Length;
            }
            else
            {
                try
                {
                    success_get_tokens = true;
                    string ints = "";
                    List<string> opartors = new List<string>();
                    List<string> ableopartors = new List<string> { "+", "-", "*", "/", "."};
                    double number = 0;

                    for (int i = 0; i < free_input_box.Text.Length; i++)
                    {
                        if (double.TryParse(free_input_box.Text.Substring(i, 1), out number) || free_input_box.Text.Substring(i, 1) == ".")
                        {
                            ints += free_input_box.Text.Substring(i, 1);
                        }
                        else
                        {
                            if (ableopartors.Contains(free_input_box.Text.Substring(i, 1)))
                            {
                                compute_all_tokens.Add(double.Parse(ints));
                                compute_using.Add(double.Parse(ints));
                                ints = "";
                                compute_duts.Add(free_input_box.Text.Substring(i, 1));
                                compute_all_tokens.Add(free_input_box.Text.Substring(i, 1));
                            }
                            else if (free_input_box.Text.Substring(i, 1) == " ")
                            { }
                            else if (free_input_box.Text.Substring(i, 1) == "(" || free_input_box.Text.Substring(i, 1) == ")")
                            {
                                compute_all_tokens.Add(free_input_box.Text.Substring(i, 1));
                            }
                            else
                            {
                                free_input_box.BackColor = Color.Red;
                                free_input_box.Text = "Syntax error!";
                                success_get_tokens = false;

                                while (free_input_box.Text == "Syntax error!")
                                {
                                    await Task.Delay(5);
                                }

                                free_input_box.BackColor = SystemColors.Window;
                                free_input_box.Text = numbers.Text;
                                free_input_box.SelectionStart = free_input_box.Text.Length;
                            }
                        }
                    }

                    compute_all_tokens.Add(double.Parse(ints));
                    compute_using.Add(double.Parse(ints));
                    ints = "";


                    for (int i = 0; i < compute_all_tokens.Count(); i++)
                    {
                        Debug.WriteLine(compute_all_tokens[i]);
                    }
                }
                catch (Exception ex)
                {
                    free_input_box.BackColor = Color.Red;
                    free_input_box.Text = "Read failed!";
                    success_get_tokens = false;

                    while (free_input_box.Text == "Read failed!")
                    {
                        await Task.Delay(5);
                    }

                    free_input_box.BackColor = SystemColors.Window;
                    free_input_box.Text = numbers.Text;
                    free_input_box.SelectionStart = free_input_box.Text.Length;
                }
            }
        }

        private void free_input_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                compute_numbers();
            }
        }

        List<Oreo> oreolist = new List<Oreo>();
        private async void read_and_makingOreo()
        {
            string get_oreo = "";
            string compute_opa = "";
            int brackets_required = 0;
            for (int i = 0; i < compute_all_tokens.Count; i++)
            {
                if (compute_all_tokens[i].ToString() == "(")
                {
                    brackets_required++;

                    if (compute_all_tokens[i] == "+" || compute_all_tokens[i] == "-" || compute_all_tokens[i] == "*" || compute_all_tokens[i] == "/")
                    {
                        compute_opa += compute_all_tokens[i];
                        get_oreo += "|";
                    }
                    else
                    {
                        get_oreo += compute_all_tokens[i];
                    }
                }
                else if (compute_all_tokens[i].ToString() == ")")
                {
                    if (brackets_required > 0)
                    {
                        brackets_required--;

                        oreolist.Add(new Oreo(get_oreo.Split('|')[0], compute_opa, get_oreo.Split('|')[1]));

                        get_oreo = "";
                        compute_opa = "";

                        MessageBox.Show(get_oreo + compute_opa);
                    }
                    else
                    {
                        free_input_box.BackColor = Color.Red;
                        free_input_box.Text = "One or more brackets are not paired!";

                        while (free_input_box.Text == "One or more brackets are not paired!")
                        {
                            await Task.Delay(5);
                        }

                        free_input_box.BackColor = SystemColors.Window;
                        free_input_box.Text = numbers.Text;
                        free_input_box.SelectionStart = free_input_box.Text.Length;
                    }
                }

                if (brackets_required > 1)
                {
                    free_input_box.BackColor = Color.Red;
                    free_input_box.Text = "One or more brackets are not paired!";

                    while (free_input_box.Text == "One or more brackets are not paired!")
                    {
                        await Task.Delay(5);
                    }

                    free_input_box.BackColor = SystemColors.Window;
                    free_input_box.Text = numbers.Text;
                    free_input_box.SelectionStart = free_input_box.Text.Length;
                }
            }
            compute_all_tokens.Clear();
        }
    }
}
