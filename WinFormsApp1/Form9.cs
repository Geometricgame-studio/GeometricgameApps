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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public DialogResult Show_MessageBox(string msg, string title, string icon, string type)
        {
            var open_msgbox = new Form();
            if (type == "OK")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.OK_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else if (type == "OKCancle")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.OKCancle_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else if (type == "OKRetry")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.CloseRetry_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else if (type == "YesNoCancle")
            {
                open_msgbox = new All_tools_Form_Apps.MessageBoxs.YesNoCancle_MessageBox(msg, title, icon);
                open_msgbox.ShowDialog();
            }
            else
            {
                MessageBox.Show("MessageBox type is null or undefind type.\n" +
                    "Type error: typemissing\nError code: M0000", "Type missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return open_msgbox.DialogResult;
        }

        private void one_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                    "1. 此服務將無法在晚上10:30後預約。\n" +
                    "2. 所有服務將在晚上11:00後結束。\n" +
                    "3. 由於人力原因，並非所有時間都能使用此服務。\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE01", "服務", "Info", "OK");
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            DialogResult result =
                            Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                                "1. 此服務將無法在晚上10:30後預約。\n" +
                                "2. 所有服務將在晚上11:00後結束。\n" +
                                "3. 由於人力原因，並非所有時間都能使用此服務。\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE02", "服務", "Info", "OK");
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                    "1. 此服務將無法在晚上10:30後預約。\n" +
                    "2. 所有服務將在晚上11:00後結束。\n" +
                    "3. 由於人力原因，並非所有時間都能使用此服務。\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE03", "服務", "Info", "OK");
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                    "1. 此服務將無法在晚上10:30後預約。\n" +
                    "2. 所有服務將在晚上11:00後結束。\n" +
                    "3. 由於人力原因，並非所有時間都能使用此服務。\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE04", "服務", "Info", "OK");
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            var o = new Form11();
            o.Show();
        }

        private void six_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                    "1. 此服務將無法在晚上10:30後預約。\n" +
                    "2. 所有服務將在晚上11:00後結束。\n" +
                    "3. 此服務只在晚上8:00後提供，對於早上洗澡的客人，深感抱歉!\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE06", "服務", "Info", "OK");
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                    "1. 此服務將無法在晚上10:30後預約。\n" +
                    "2. 所有服務將在晚上11:00後結束。\n" +
                    "3. 由於人力原因，並非所有時間都能使用此服務。\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE07", "服務", "Info", "OK");
            }
        }

        private void other_need_Click(object sender, EventArgs e)
        {
            DialogResult result =
                Show_MessageBox("在使用此服務之前您必須嘹解:\n" +
                    "1. 此服務將無法在晚上10:30後預約。\n" +
                    "2. 所有服務將在晚上11:00後結束。\n" +
                    "3. 如果需求不再合適範圍內，將無法提供服務。\n按下 確定 即代表同意以上規則!", "服務須知", "Warning", "OKCancle");
            if (result == DialogResult.OK)
            {
                Show_MessageBox("請將此對話框給服務人員看\n\nSVE01", "服務", "Info", "OK");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Show_MessageBox("什麼? 還在手動退房嗎?!\n此飯店具有自動退房機制，所以您無須擔心退房問題" +
                "\n如果您只是想離開此頁面，請洽服務人員。", "自動退房", "Info", "OK");
        }

        private async void Form9_Load(object sender, EventArgs e)
        {
            while (true) {
                DateTime now = DateTime.Now;
                Time.Text = now.Year + "/" + now.Month + "/" + now.Day + "\n"
                    + now.Hour + ":" + now.Minute + ":" + now.Second;
                await Task.Delay(1000);
            }
        }
    }
}
