using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerformanceOfAddSubtractIncrementMultiplyDivide
{
    class AddMethodsTest
    {
        public static void IntTest(int lengthCount)
        {
            int sum = 1;
            for (int i = 0; i < lengthCount; i++)
            {
                sum += sum;
            }
        }
        public static void LongTest(int lengthCount)
        {
            long sum = 1L;
            for (int i = 0; i < lengthCount; i++)
            {
                sum += sum;
            }
        }
        public static void FloatTest(int lengthCount)
        {
            float sum = 1.0f;
            for (int i = 0; i < lengthCount; i++)
            {
                sum += sum; 
            }
        }
        public static void DoubleTest(int lengthCount)
        {
            double sum = 1.0d;
            for (int i = 0; i < lengthCount; i++)
            {
                sum += sum;
            }
        }
        public static void DecimalTest(int lengthCount)
        {
            decimal sum = 1m;
            for (int i = 0; i < lengthCount; i++)
            {
                sum += sum;
            }
        }
    }
}
