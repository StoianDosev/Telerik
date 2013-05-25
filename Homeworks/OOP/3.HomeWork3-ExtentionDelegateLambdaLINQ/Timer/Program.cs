using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Threading;

namespace Timer
{
    public delegate void DelegateFunc(int item); 
    class Program
    {
        static void Main(string[] args)
        {
            //delegate holds two functions from Timer class
            DelegateFunc del = Timer.CountTo;
            del += Timer.WriteLine;

            Timer timer = new Timer(1000);//Seting the time for execution in the constructor
            while (true)
            {
                Thread.Sleep(timer.ExecuteTime);
                del(10);// delegate gives the input to its functions
            }
        }
    }
}
