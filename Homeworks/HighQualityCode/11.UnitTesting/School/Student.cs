using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : School
    {
        //field
        private int number;

        //constructor
        public Student(string name, int number):base(name)
        {
            this.Number = number;
        }

        //property
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("The number should be in the range from 10000 to 99999.");
                }
                this.number = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Student's name: {0}, ID: {1}", this.Name, this.Number);
            return builder.ToString();
        }
    }
}
