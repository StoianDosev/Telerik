using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerformanceOfAddSubtractIncrementMultiplyDivide
{
    class SubstractMethodsTest
    {
        public static void IntTest(int lengthCount)
        {
            int result = int.MaxValue;
            for (int i = 0; i < lengthCount; i++)
            {
                result = result - 1;
            }
        }

        public static void LongTest(int lengthCount)
        {
            long result = long.MaxValue;
            for (int i = 0; i < lengthCount; i++)
            {
                result = result - 1;
            }
        }

        public static void FloatTest(int lengthCount)
        {
            float result = float.MaxValue;
            for (int i = 0; i < lengthCount; i++)
            {
                result = result - 1.0f;
            }
        }

        public static void DoubleTest(int lengthCount)
        {
            double result = double.MaxValue;
            for (int i = 0; i < lengthCount; i++)
            {
                result = result - 1.0d;
            }
        }

        public static void DecimalTest(int lengthCount)
        {
            decimal result = decimal.MaxValue;
            for (int i = 0; i < lengthCount; i++)
            {
                result = result - 1m;
            }
        }
    }
}
