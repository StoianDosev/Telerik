using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerformanceOfAddSubtractIncrementMultiplyDivide
{
    class DivideMethodsTest
    {
        public static void IntTest(int countNumber, int divider)
        {
            int result = 0;
            for (int i = 0; i < countNumber; i++)
            {
                result = i / divider;
            }
        }
        public static void LongTest(int countNumber, long divider)
        {
            long result = 0;
            for (int i = 0; i < countNumber; i++)
            {
                result = i / divider;
            }
        }
        public static void FloatTest(int countNumber, float divider)
        {
            float result = 0.0f;
            for (int i = 0; i < countNumber; i++)
            {
                result = i / divider;
            }
        }
        public static void DoubleTest(int countNumber, double divider)
        {
            double result = 0;
            for (int i = 0; i < countNumber; i++)
            {
                result = i / divider;
            }
        }
        public static void DecimalTest(int countNumber, decimal divider)
        {
            decimal result = 0;
            for (int i = 0; i < countNumber; i++)
            {
                result = i / divider;
            }
        }
    }
}
