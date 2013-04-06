using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
 It should hold error message and a range definition [start … end].Write a sample application that demonstrates 
 the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and 
 dates in the range [1.1.1980 … 31.12.2013].*/


namespace DefineException
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            string startStr = "1.1.1980";
            string endStr = "31.12.2013";

            // new instances for the custum generic exception class
            InvalidRangeException<int> intException = new InvalidRangeException<int>(start, end, "Invalid range of numbers.");
            InvalidRangeException<DateTime> dateException = new InvalidRangeException<DateTime>(DateTime.Parse(startStr), DateTime.Parse(endStr), "Invalid date range.");

            //using the try-catch construction for both exception classes
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < intException.Start || number > intException.End)
                {
                    throw intException;
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("The format of the number is invalid.");
            }
            try
            {
                DateTime date = DateTime.Parse(Console.ReadLine());
                if (date < dateException.Start || date > dateException.End)
                {
                    throw dateException;
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {

                Console.WriteLine(e.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("The date format is invalid.");
            }
        }
    }
}
