using System;

//2.Refactor the following code to apply variable usage and naming best practices.

namespace PrintStatistic
{
    class Program
    {
        static void Main()
        {
            Statistic example = new Statistic();
            double[] array = new double[] { 1, 2, 3, 4, 5, 6 };
            example.PrintMaxMinAndAvarageOfArray(array);
        }
    }
}
