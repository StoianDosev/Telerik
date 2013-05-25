using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Frog : Animals
    {
        //constructor
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {
        }

        //mathod form Animal
        public override void ProduceSoun()
        {
            Console.WriteLine("Quack");
        }
    }
}
