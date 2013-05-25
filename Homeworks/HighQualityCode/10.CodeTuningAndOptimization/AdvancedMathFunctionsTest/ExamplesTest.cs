using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMathFunctionsTest
{
    class ExamplesTest
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            NaturalLogarithm.FloatTest();
            watch.Stop();
            Console.WriteLine("Natural logarithm with float value time test: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            NaturalLogarithm.DoubleTest();
            watch.Stop();
            Console.WriteLine("Natural logarithm with double value time test: " + watch.Elapsed);
            watch.Reset();

            watch.Start();
            NaturalLogarithm.DecimalTest();
            watch.Stop();
            Console.WriteLine("Natural logarithm with decimal value time test: " + watch.Elapsed);
            watch.Reset();

        }
    }
}
