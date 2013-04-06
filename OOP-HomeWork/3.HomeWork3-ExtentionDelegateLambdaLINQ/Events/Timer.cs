using System;

namespace Events
{
    // Publisher
    class Timer
    {
        private int executeTime;

        public event EventHandler<TimerTickEventArgs> TimerTickEvent;//event handler

        //constructors
        public Timer()
            : this(500)
        {
        }
        public Timer(int timer)
        {
            this.executeTime = timer;
        }

        //property
        public int ExecuteTime
        {
            get { return this.executeTime; }
            set { this.executeTime = value; }
        }

        //some methods of the class
        public static void CountTo(int count)
        {

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void WriteLine(int n)
        {

            Console.WriteLine(DateTime.Now);
        }

        //Method which will call the event
        public void Tick()
        {
            OnRaiseTimerTickEvent(new TimerTickEventArgs("This is tick!"));
        }

        //this method will handle the event
        protected virtual void OnRaiseTimerTickEvent(TimerTickEventArgs e)
        {
            EventHandler<TimerTickEventArgs> handler = TimerTickEvent;

            if (handler != null)
            {
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());
                handler(this, e);
            }
        }
    }

    
}
