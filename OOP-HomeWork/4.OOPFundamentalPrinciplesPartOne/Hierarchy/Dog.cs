using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Dog : Animals
    {
        //constuctor
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        {
        }
        // method from Animal
        public override void ProduceSoun()
        {
            Console.WriteLine("Bay Bay");
        }
    }
}
