using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Animals : ISound
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        //constructor
        public Animals(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }


        //abstract method from ISound
        public abstract void ProduceSoun();

        //method
        public static double Average(Animals[] array)
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result+= array[i].Age;
            }
            return result / array.Length;
        }
    }
}
