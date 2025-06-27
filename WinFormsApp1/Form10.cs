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
    public partial class Form10 : Form
    {
        List<DateTime> alarms_time = new List<DateTime>();
        List<string> alarms_name = new List<string>();
        System.Timers.Timer timer;
        public Form10()
        {
            InitializeComponent();

            
        }

        private void Add_alarm_Click(object sender, EventArgs e)
        {
            Alarm_table.ColumnCount = 2;
            Alarm_table.RowCount = Alarm_table.RowCount + 1;
            Alarm_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            Alarm_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            Alarm_table.Controls.Add(new Label() { Text = alarm_name.Text }, 0, Alarm_table.RowCount);
            Alarm_table.Controls.Add(new Label() { Text = TimePicker.Value.ToString() }, 1, Alarm_table.RowCount);
        }

        private async void Form10_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            Program.show_notify
                ("功能尚未完善!", "此功能尚未完成，如果繼續使用，可能會造成錯誤!", 1500, "warning", false);  
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
            DateTime time_now = DateTime.Now;
            DateTime user_time = alarms_time[0];
            if (alarms_time.Count > 0)
            {
                if (time_now.Hour == user_time.Hour && time_now.Minute == user_time.Minute
                    && time_now.Second == user_time.Second)
                {
                    this.WindowState = FormWindowState.Normal;
                    MessageBox.Show("於" + alarms_time[0] + " 的 " + alarms_name[0] + " 到了!",
                        alarms_name[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alarms_time.RemoveAt(0);
                }
            }
        }
    }
}
