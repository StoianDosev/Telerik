using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Subscriber//class for the subscribers for the event
    {
        private string id;//the field holds the id of the each instance of the class
        public Subscriber(string name, Timer publisher)//constructor
        {
            id = name;
            publisher.TimerTickEvent += WriteEventMessage;
        }

        void WriteEventMessage(object sender, TimerTickEventArgs e)//method for the subscribers
        {
            Console.WriteLine(this.id + " received this message: {0}", e.Message);
        }
    }
}