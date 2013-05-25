using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Kitten : Cat
    {
        //constructor
        public Kitten(int age,string name): base(age,name,"female")
        {
        }

        // method from Cat
        public override void ProduceSoun()
        {
            Console.WriteLine(base.Name + " says: Mayy");
        }
    }
}
