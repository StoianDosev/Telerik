using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTests
{
    public class ArrayOperations
    {
        private static Random randum = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static void CreateIntArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = randum.Next();
        }

        public static void CreateDoubleArray(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = randum.NextDouble();
        }

        public static void CreateStringArray(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
                strings[i] = GenerateStringFromCharArray();
        }

        public static void ReverseArray<T>(T[] elements) where T : IComparable
        {
            Array.Sort(elements, new Comparison<T>(
                    (x, y) => y.CompareTo(x)
                ));
        }

        private static string GenerateStringFromCharArray()
        {
            int length = randum.Next(1, 25);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
                builder.Append(Chars[randum.Next(0, Chars.Length)]);

            return builder.ToString();
        }
    }
}
