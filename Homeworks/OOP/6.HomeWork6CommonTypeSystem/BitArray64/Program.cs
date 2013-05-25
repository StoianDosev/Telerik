using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), 
 GetHashCode(), [], == and !=.*/

namespace BitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 bitArray = new BitArray64();

            bitArray[0] = 1;
            bitArray[63] = 1;
            bitArray[62] = 1;
            bitArray[63] = 0;

            BitArray64 bitArray2 = new BitArray64();
            bitArray2[12] = 1;
            bitArray2[21] = 1;
            bitArray2[63] = 1;

            Console.WriteLine(bitArray2.Equals(bitArray));
            Console.WriteLine(bitArray2 != bitArray);

            Console.WriteLine("The value of the first BitArray64 is: {0}",bitArray);
            Console.WriteLine("Using foreach for first BitArray64:");
            foreach (var number in bitArray)
            {
                Console.Write(number);
            }

            Console.WriteLine();

            Console.WriteLine("The value of the second BitArray64 is: {0}", bitArray2);
            Console.WriteLine("Using foreach for second BitArray64:");
            foreach (var number in bitArray2)
            {
                Console.Write(number);
            }

            Console.WriteLine();


            IEnumerator enumerator = bitArray.GetEnumerator();

            Console.WriteLine("Using enumerator:");

            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current);
            }
            Console.WriteLine();
        }
    }
}
