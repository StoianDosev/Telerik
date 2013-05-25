using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionIEnumerableT
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>() { "A","dsdf","1"};
            List<int> li = new List<int>() { 1, 2, 3, 9 };
            Console.WriteLine("The sum is: " + list.Sum());
            Console.WriteLine("The min of the elements is: " + li.Min());
            Console.WriteLine("The max of the elements is: " + li.Max());
            Console.WriteLine("The avarage of the elements is: " + li.Avarage());
            Console.WriteLine("The avarage of the elements is: " + li.Product());

        }
    }
}
