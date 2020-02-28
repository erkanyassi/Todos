using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

namespace todolist.Helpers
{
    public class AlertTimeClass
    {
        public AlertTimeClass(DateTime todoTime)
        {
            this.todoTime = todoTime;

            timer = new Timer();
            timer.Elapsed += timer_Elapsed;
            timer.Interval = 1000;
            timer.Start();

            enabled = true;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (enabled && DateTime.Now > todoTime)
            {
                enabled = false;
                OnAlarm();
                timer.Stop();
            }
        }

        protected virtual void OnAlarm()
        {
            if (alarmEvent != null)
                alarmEvent(this, EventArgs.Empty);
        }


        public event EventHandler Alarm
        {
            add { alarmEvent += value; }
            remove { alarmEvent -= value; }
        }

        private EventHandler alarmEvent;
        private Timer timer;
        private DateTime todoTime;
        private bool enabled;
    }
}