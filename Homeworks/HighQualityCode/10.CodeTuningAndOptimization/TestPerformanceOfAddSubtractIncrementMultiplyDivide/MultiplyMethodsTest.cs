using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerformanceOfAddSubtractIncrementMultiplyDivide
{
    class MultiplyMethodsTest
    {
        public static void IntTest(int countNumber, int multiplyNumber)
        {
            int result = 1;
            for (int i = 0; i < countNumber; i++)
            {
                result = result * multiplyNumber;
            }
        }

        public static void LongTest(int countNumber, long multiplyNumber)
        {
            long result = 1;
            for (int i = 0; i < countNumber; i++)
            {
                result = result * multiplyNumber;
            }
        }

        public static void FloatTest(int countNumber, float multiplyNumber)
        {
            float result = 1;
            for (int i = 0; i < countNumber; i++)
            {
                result = result * multiplyNumber;
            }
        }

        public static void DoubleTest(int countNumber, double multiplyNumber)
        {
            double result = 1;
            for (int i = 0; i < countNumber; i++)
            {
                result = result * multiplyNumber;
            }
        }

        public static void DecimalTest(int countNumber, decimal multiplyNumber)
        {
            decimal result = 1;
            for (int i = 0; i < countNumber; i++)
            {
                result = result * multiplyNumber;
            }
        }
    }
}
