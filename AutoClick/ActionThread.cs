using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    internal class ActionThread
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;      // The left button is down.
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;


        private Thread thread;

        private List<AutoClickInput> actionList;
        private int milTime;
        private bool isStopped = true;


        public ActionThread(List<AutoClickInput> actionList, int milTime)
        {
            this.actionList = actionList;
            this.milTime = milTime;

            this.thread = new Thread(new ThreadStart(run));
        }

        public void start()
        {
            this.isStopped = false;
            this.thread.Start();
        }

        public void stop()
        {
            this.isStopped = true;
            //this.thread.Abort();
            this.thread.Join();
        }

        private void run()
        {
            if(!this.isStopped)
            {
                while(!this.isStopped)
                {
                    int delta = this.getNow() - this.milTime;
                    if(delta <= 60000 && delta >= 0 && !this.isStopped)
                    {
                        this.actionStart(delta);
                        break;
                    }

                    //Thread.Sleep(30000);
                }
            }
        }

        private void actionStart(int delta)
        {
            if(!this.isStopped)
            {
                if(delta > 0)
                {
                    Console.WriteLine(delta.ToString());
                    //Thread.Sleep(delta);
                }
                
                for(int i = 0; i < actionList.Count; i++)
                {
                    if(this.isStopped)
                    {
                        break;
                    }

                    AutoClickInput action = actionList[i];
                    if(action.getInputType() == AutoClickInput.TYPE_MOUSE)
                    {
                        Cursor.Position = action.getInputPoint();

                        if(action.getKeyCode() == AutoClickInput.ACTION_LEFT_CLICK)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                        else
                        {
                            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                        }
                    }
                    else
                    {
                        // keyvoard action

                    }
                    Thread.Sleep(action.getDelay());
                }
            }
        }

        private int getNow()
        {
            DateTime now = DateTime.Now;
            return this.timeToMilSec(now.Hour, now.Minute, now.Second);
        }

        private int timeToMilSec(int hour, int minute, int second)
        {
            int milSec = second * 1000;
            int milMin = minute * 1000 * 60;
            int milHour = hour * 1000 * 60 * 60;
            return milHour + milMin + milSec;
        }
    }
}
