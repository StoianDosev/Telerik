using System;

namespace CohesionAndCoupling
{
    //3.Take the VS solution "Cohesion-and-Coupling" and refactor its code to follow the principles of good abstraction,
    //loose coupling and strong cohesion. Split the class Utils to other classes that have strong cohesion and are loosely coupled internally.

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                TwoDimensionalUtils.CalculateDistance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                ThreeDimensionalUtils.CalculateDistance(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", ThreeDimensionalUtils.CalculateVolume(12, 24, 45));
            Console.WriteLine("Diagonal XYZ = {0:f2}", ThreeDimensionalUtils.CalculateDiagonal(5, 6, 8));
            Console.WriteLine("Diagonal XY = {0:f2}", TwoDimensionalUtils.CalculateDiagonalBetweenPoints(6, 8));
            Console.WriteLine("Diagonal XZ = {0:f2}", TwoDimensionalUtils.CalculateDiagonalBetweenPoints(6.7, 12));
            Console.WriteLine("Diagonal YZ = {0:f2}", TwoDimensionalUtils.CalculateDiagonalBetweenPoints(7.8, 76));
        }
    }
}
