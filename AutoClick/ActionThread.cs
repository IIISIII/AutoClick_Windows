using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace AutoClick
{
    internal class ActionThread
    {
        private System.Timers.Timer timer;

        private List<AutoClickInput> actionList;
        private int milTime;
        private bool isStopped = true;
        private bool isRunning = false;
        private bool isCompleted = true;


        public ActionThread(List<AutoClickInput> actionList, int milTime)
        {
            this.actionList = actionList;
            this.milTime = milTime;

            this.timer = new System.Timers.Timer();
            this.timer.Interval = 30000;
            this.timer.Elapsed += new ElapsedEventHandler(onTimer);
        }

        public void start()
        {
            this.isStopped = false;

            run();
            this.timer.Start();
        }

        public void stop()
        {
            this.isStopped = true;

            this.timer.Stop();
        }

        private void onTimer(Object source, ElapsedEventArgs e)
        {
            if(!this.isRunning)
            {
                run();
            }

            if(this.isCompleted)
            {
                this.isRunning = false;
            }
        }

        private void run()
        {
            int delta = this.milTime - this.getNow();

            if (delta <= 60000 && delta >= 0 && !this.isStopped)
            {
                this.actionStart(delta);
            }
        }

        private void actionStart(int delta)
        {
            this.isCompleted = false;
            this.isRunning = true;

            if (!this.isStopped)
            {
                Console.WriteLine(delta.ToString());
                if (delta > 0)
                {
                    Task.Delay(delta).ContinueWith(task => { eventAction(actionList, 0); });
                }
                else
                {
                    eventAction(actionList, 0);
                }
            }
            else
            {
                this.isCompleted = true;
            }
        }

        private void eventAction(List<AutoClickInput> actionList, int index)
        {
            if(actionList.Count <= index || this.isStopped)
            {
                this.isCompleted = true;
                return;
            }

            AutoClickInput action = actionList[index];
            int delay = action.getDelay();

            if(delay > 0)
            {
                Task.Delay(delay).ContinueWith(task => {
                    doAction(action);
                    eventAction(actionList, index + 1);
                });
            }
            else
            {
                this.doAction(action);
                this.eventAction(actionList, index + 1);
            }
        }

        private void doAction(AutoClickInput action)
        {
            if (action.getInputType() == AutoClickInput.TYPE_MOUSE)
            {
                MouseEvent.press(action.getInputPoint(), action.getMouseInput() == AutoClickInput.ACTION_LEFT_CLICK);
            }
            else
            {
                List<KeyGroup> keys = action.getKeyGroups();
                for(int i = 0; i < keys.Count; i ++)
                {
                    KeyboardEvent.press(keys[i]);
                }
            }

            //Console.WriteLine(KeyboardState.isEnglish().ToString());
        }

        private int getNow()
        {
            DateTime now = DateTime.Now;
            return TimeSelector.timeToMilSec(now.Hour, now.Minute, now.Second);
        }
    }
}
