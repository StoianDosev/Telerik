using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOPPrinciplesPartOne
{
    class Student : Students
    {
        //property
        public int Number { get; private set; }

        //constructor
        public Student(string name, int number)
        {
            base.Name = name;
            this.Number = number;

        }
    }
}
