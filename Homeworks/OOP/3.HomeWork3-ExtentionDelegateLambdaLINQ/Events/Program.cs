using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(1000);//class which holds the event

            //Subscribers for the event
            Subscriber sub1 = new Subscriber("First Subscriber", timer);
            Subscriber sub2 = new Subscriber("Second Subscriber", timer);



            int counter = 0;
            while (true)
            {
                Thread.Sleep(timer.ExecuteTime);
                //function which will call the event
                timer.Tick();
                Console.WriteLine(counter++);
                
            }
           
        }
    }
}
