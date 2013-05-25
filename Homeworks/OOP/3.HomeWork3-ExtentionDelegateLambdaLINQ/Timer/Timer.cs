using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {
        private int executeTime;// private feild

        public Timer(): this(500) //empty costructors
        {
        }

        public Timer(int timer)// non-empty constructor
        {
            this.executeTime = timer;
        }

        public int ExecuteTime// public property
        {
            get { return this.executeTime; }
            set { this.executeTime = value; }
        }

        public static void CountTo(int count)//Function which will go to the delegate
        {
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i); 
            }
        }
        public static void WriteLine(int n)//Another function for the delegate
        {
            
            Console.WriteLine(DateTime.Now);
        }
    }
}
