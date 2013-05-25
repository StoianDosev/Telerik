using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main()
        {


            Point3D a = new Point3D(1, 2, 3);
            Point3D b = new Point3D(4, 5, 6);
            Point3D c = new Point3D(7, 8, 9);
            Point3D d = new Point3D(10, 11, 12);

            double distance = Distance.CalculateDistance(a, d);
            Console.WriteLine("The distance between point with coordinates: {0} and point with coordinates: {1} is {2}. " + Environment.NewLine, a, d, distance);

            Path path1 = new Path();
            path1.AddPoints(a);
            path1.AddPoints(b);
            Console.WriteLine(path1);

            Path path2 = new Path();
            path2.AddPoints(c);
            path2.AddPoints(d);
            Console.WriteLine(path2);

            Path pathZero = new Path();
            pathZero.AddPoints(Point3D.ZeroPoint);

            Console.WriteLine(path1 + path2);// using "+" operator
            Path p = new Path();

            PathStorage.WritePaths(path1);
            PathStorage.WritePaths(path2);
            PathStorage.WritePaths((path1 + path2));

            p = PathStorage.LoadPaths();
            Console.WriteLine(p);


        }
    }
}
