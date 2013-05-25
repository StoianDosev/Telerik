using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program 
    {
        static void Main()
        {
           
            Generic<string> s = new Generic<string>();
            Generic<int> n = new Generic<int>(5);

            n.AddElement(5);
            n.AddElement(6);
            n.AddElement(7);
            n.AddElement(8);
            n.AddElement(9);
            Console.WriteLine(n);
            n.InsertElementOnPosition(10, 1);
            Console.WriteLine(n);
            Console.WriteLine(n.Max());
            Console.WriteLine(n.Min());
            n.RemoveElementByIndex(1);
            Console.WriteLine(n);
            Console.WriteLine(n.FindElement(6));

            s.AddElement("a");
            s.AddElement("b");
            s.AddElement("c");
            s.AddElement("d");
            s.InsertElementOnPosition("w", 3);
            s.InsertElementOnPosition("z", 4);
            Console.WriteLine(s.AccessElementByIndex(1));
            Console.WriteLine(s);
            Console.WriteLine("The maximal element is {0}", s.Max());
            Console.WriteLine("The minimal element is {0}", s.Min());
            s.RemoveElementByIndex(1);
            Console.WriteLine(s);
            string a = "a";
            s.FindElement(a);
            Console.WriteLine( "The index of {0} is {1}.",a,s.FindElement("a"));
            s.Clear();
            Console.WriteLine(s);
        }
    }
}
