using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("The sum of the two sides of the triangle should be greater than the third side.");
            }

            double heronEquasion = (a + b + c) / 2;
            double triangleArea = Math.Sqrt(heronEquasion * (heronEquasion - a) * (heronEquasion - b) * (heronEquasion - c));
            return triangleArea;
        }

        static string NumberInEnglish(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid number!");
        }

        static int FindMaxElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("There are no elements in the input.");
            }

            int maxElement = int.MinValue;
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index] > maxElement)
                {
                    maxElement = elements[index];
                }
            }
            return maxElement;
        }

        static void PrintToSecondDigitPrecision(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        static void PrintPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintNumberOnEightPosition(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static double DistanceTwoBetweenCoordinates(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static bool AreCoordinatesVertical(double x1, double x2)
        {
            bool areVertical = x1 == x2;
            return areVertical;
        }

        static bool AreCoordinatesHorizontal(double y1, double y2)
        {
            bool areHorizontal = y1 == y2;
            return areHorizontal;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 5, 5));
            Console.WriteLine(NumberInEnglish(5));
            Console.WriteLine(FindMaxElement(5, -1, 3, 2, 14, 2, 3));

            PrintToSecondDigitPrecision(1.3);
            PrintPercent(0.75);
            PrintNumberOnEightPosition(2.30);

            Console.WriteLine(DistanceTwoBetweenCoordinates(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + AreCoordinatesVertical(3, 3));
            Console.WriteLine("Vertical? " + AreCoordinatesHorizontal(-1, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.Information = new PersonalInformation("17.03.1992", "Sofia");

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.Information = new PersonalInformation("03.11.1993", "gamer", "Vidin");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
