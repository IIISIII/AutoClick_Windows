using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class TimeSelector : UserControl
    {
        private bool isAm = true;

        public TimeSelector()
        {
            InitializeComponent();
        }

        private void OnChangedAmPm(object sender, EventArgs e)
        {
            this.isAm = radioAM.Checked;
        }

        public void setTime(int hour, int minute, int second)
        {
            if (hour >= 12)
            {
                hourUpDown.Value = hour - 12;
                radioAM.Checked = false;
                radioPM.Checked = true;
            }
            else
            {
                hourUpDown.Value = hour;
                radioPM.Checked = false;
                radioAM.Checked = true;
            }
            minuteUpDown.Value = minute;
            secondUpDown.Value = second;
        }
        public void initToNow()
        {
            DateTime now = DateTime.Now;
            this.setTime(now.Hour, now.Minute, now.Second);
        }

        public int getHour()
        {
            return Convert.ToInt32(hourUpDown.Value) + (isAm ? 0 : 12);
        }

        public int getMinute()
        {
            return Convert.ToInt32(minuteUpDown.Value);
        }

        public int getSecond()
        {
            return Convert.ToInt32(secondUpDown.Value);
        }

        public void disable()
        {
            radioAM.Enabled = false;
            radioPM.Enabled = false;
            hourUpDown.Enabled = false;
            minuteUpDown.Enabled = false;
            secondUpDown.Enabled = false;
        }

        public void enable()
        {
            radioAM.Enabled = true;
            radioPM.Enabled = true;
            hourUpDown.Enabled = true;
            minuteUpDown.Enabled = true;
            secondUpDown.Enabled = true;
        }

        public static int timeToMilSec(int hour,  int minute, int second)
        {
            int milSec = second * 1000;
            int milMin = minute * 1000 * 60;
            int milHour = hour * 1000 * 60 * 60;
            return milHour + milMin + milSec;
        }
    }
}
