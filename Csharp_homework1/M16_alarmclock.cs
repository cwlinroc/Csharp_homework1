using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    public partial class M16_alarmclock : Form
    {


        bool alarmswitch = false;
        public M16_alarmclock()
        {
            InitializeComponent();
            RefreshClockMessage();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            alarmswitch = true;
            label_status.Text = "啟動中...";
            datetimepicker_alarmtime.Enabled = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            alarmswitch = false;
            label_status.Text = "未啟動";
            datetimepicker_alarmtime.Enabled = true ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshClockMessage();
            DateTime now = DateTime.Now;
            DateTime alarm = datetimepicker_alarmtime.Value;

            if (alarmswitch && now.Hour == alarm.Hour 
                && now.Minute == alarm.Minute && now.Second == alarm.Second ) 
            {
                TriggerAlarm();
            }

        }

        private void RefreshClockMessage()
        {
            string message;

            if (DateTime.Now.Hour < 12)
            {
                message = $"上午  {DateTime.Now.Hour.ToString("D2")}" +
                    $":{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}";
            }
            else if (DateTime.Now.Hour == 12)
            {
                message = $"下午  {DateTime.Now.Hour.ToString("D2")}" +
                    $":{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}";
            }
            else
            {
                message = $"下午  {(DateTime.Now.Hour - 12).ToString("D2")}" +
                    $":{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}";
            }

            label_clock.Text = message;

        }

        private void TriggerAlarm()
        {
            MessageBox.Show("該醒啦");

            btn_stop.PerformClick();
        }


    }
}
