using System;

namespace PrintStatistic
{
    class Statistic
    {
        public void PrintMaxMinAndAvarageOfArray(double[] arr)
        {
            Console.WriteLine("The max number is: {0}.", FindMaxNumber(arr));
            Console.WriteLine("The min number is: {0}.", FindMinNumber(arr));
            Console.WriteLine("The avarage number is: {0}.", FindAvarageNumber(arr));
        }

        private double FindAvarageNumber(double[] arr)
        {
            double sum = 0;

            for (int index = 0; index < arr.Length; index++)
            {
                sum += arr[index];
            }
            return sum / arr.Length;
        }

        private double FindMinNumber(double[] arr)
        {
            double minNumber = double.MaxValue;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] < minNumber)
                {
                    minNumber = arr[index];
                }
            }
            return minNumber;
        }

        private double FindMaxNumber(double[] arr)
        {
            double maxNumber = double.MinValue;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] > maxNumber)
                {
                    maxNumber = arr[index];
                }
            }
            return maxNumber;
        }
    }
}
