using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOPPrinciplesPartOne
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pesho", 12);
            Console.WriteLine(student.Name);
            Disciplenes d = new Disciplenes("Maths", 5, 6);
            Console.WriteLine(d.Name);
            Teacher t = new Teacher("Gosho");
           
            Console.WriteLine(t.Name + " " + d.Name);
        }
    }
}
