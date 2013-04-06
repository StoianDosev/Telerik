using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        //properties
        public string Name { get; set; }
        public int? Age { get; set; }

        //constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // empty constructor
        public Person()
        {
        }

        //overriding ToString
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Person's name: {0} and age: {1}. ", this.Name ?? "<unknown>", (this.Age != null ? this.Age.ToString() : "<unknown>"));
            return builder.ToString();
        }
    }
}
