using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerformanceOfAddSubtractIncrementMultiplyDivide
{
    class Examples
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            int countNumber = 80;

            watch.Start();
            AddMethodsTest.IntTest(countNumber);
            watch.Stop();
            Console.WriteLine("Int add test time: "+ watch.Elapsed);
            watch.Reset();

            watch.Start();
            AddMethodsTest.LongTest(countNumber);
            watch.Stop();
            Console.WriteLine("Long add test time: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            AddMethodsTest.FloatTest(countNumber);
            watch.Stop();
            Console.WriteLine("Float add test time: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            AddMethodsTest.DoubleTest(countNumber);
            watch.Stop();
            Console.WriteLine("Double add test time: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            AddMethodsTest.DecimalTest(countNumber);
            watch.Stop();
            Console.WriteLine("Decimal add test time: " + watch.Elapsed);
            watch.Reset();
        }
    }
}
