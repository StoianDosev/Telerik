using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        List<T> result = new List<T>();
        if (startIndex > arr.Length-1)
        {
            throw new ArgumentOutOfRangeException("The start index should be smaller than the lenght of the array.");
        }
        if (startIndex + count > arr.Length )
        {
            throw new IndexOutOfRangeException("The count is bigger than the length of the array.");
        }

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("The count is bigger than the length of the input string.");
        }
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("The count cannot be negative number.");
        }
        if (str == null)
        {
            throw new NullReferenceException("The input string cannot be null.");
        }


        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number < 0)
        {
            throw new ArithmeticException("The number cannot be negative.");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        try
        {
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);

            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            int number = 23;
            bool isPrime = CheckPrime(number);
            Console.WriteLine(number + "is prime." + isPrime);
            number = 33;
            isPrime = CheckPrime(number);
            Console.WriteLine(number + "is prime." + isPrime);
            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));
        }
        catch (ArgumentOutOfRangeException ar)
        {
            Console.WriteLine(ar);
        }
        catch (ArgumentNullException an)
        {
            Console.WriteLine(an);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae);
        }
        catch (IndexOutOfRangeException ie)
        {
            Console.WriteLine(ie);
        }
        catch (ArithmeticException ae)
        {
            Console.WriteLine(ae);
        }
        catch (NullReferenceException ne)
        {
            Console.WriteLine(ne);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

       
    }
}
