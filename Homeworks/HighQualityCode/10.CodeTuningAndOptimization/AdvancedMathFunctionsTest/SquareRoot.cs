using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMathFunctionsTest
{
    class SquareRoot
    {
        public static void FloatTest()
        {
            for (float i = 1.0f; i < 1000.0f; i++)
            {
                Math.Sqrt(i);
            }
        }
        public static void DoubleTest()
        {
            for (double i = 1.0d; i < 1000.0d; i++)
            {
                Math.Sqrt(i);
            }
        }
        public static void DecimaltTest()
        {
            for (decimal i = 1.0m; i < 1000m; i++)
            {
                Math.Sqrt((double)i);
            }
        }
    }
}
