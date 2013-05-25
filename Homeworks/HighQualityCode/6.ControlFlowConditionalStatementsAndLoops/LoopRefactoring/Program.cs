using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopRefactoring
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 5, 10 };
            bool isValueFound = false;
            int expectedValue = 5;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == expectedValue)
                {
                    isValueFound = true;
                }

                Console.WriteLine(array[index]);
            }

            if (isValueFound)
            {
                Console.WriteLine("Value {0} - Found.", expectedValue);
            }
            else
            {
                Console.WriteLine("Value {0} - Not Found.", expectedValue);
            }
        }
    }
}
