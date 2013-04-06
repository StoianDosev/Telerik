using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllNumbersDevidedOnSevenAndThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 21, 63 };
            int[] array = new int[] { 1, 189, 3, 4, 21, 63 };


            //Conventional for List type
            List<int> newList = list.DevidedOnSevenAndThree();

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Conventional for array type
            int[] arr = array.DevidedOnSevenAndThreeArray();
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Lambda for list type
            var LambdaList = list.FindAll(x => x % 21 == 0);
            foreach (var item in LambdaList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Lambda for array type
            var LambdaArray = array.Where(x => x % 21 == 0);
            foreach (int item in LambdaArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //LINQ for list type

            var LINQList = from num in list
                           where num % 21 == 0
                           select num;

            foreach (var item in LINQList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //LINQ for array type
            var LINQArray = from num in array
                            where num % 21 == 0
                            select num;
            foreach (var item in LINQArray)
            {
                Console.WriteLine(item);
            }


        }
    }
}
