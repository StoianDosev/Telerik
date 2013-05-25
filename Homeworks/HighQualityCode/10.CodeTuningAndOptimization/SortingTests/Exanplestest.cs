using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTests
{
    class Exanplestest
    {
        static void Main(string[] args)
        {
            double[] doubleArray = new double[1000];
            ArrayOperations.CreateDoubleArray(doubleArray);
            Stopwatch watch = new Stopwatch();

            watch.Start();
            ArraySort.QuickSort((double[])doubleArray.Clone());
            watch.Stop();
            Console.WriteLine("Quick sort time: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            ArraySort.InsertionSort((double[])doubleArray.Clone());
            watch.Stop();
            Console.WriteLine("Insertion sort time: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            ArraySort.SelectionSort((double[])doubleArray.Clone());
            watch.Stop();
            Console.WriteLine("Select sort time: " + watch.Elapsed);
            watch.Reset();
        }
    }
}
