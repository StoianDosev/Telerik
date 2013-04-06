using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Define abstract class Shape with only one abstract method CalculateSurface() 
// and fields width and height. Define two new classes Triangle and Rectangle that 
// implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). 
// Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement 
// the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for 
// different shapes (Circle, Rectangle, Triangle) stored in an array.


namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
           Shape[] array = 
            {
                new Circle(5),
                new Rectangle(4,5),
                new Triangle(5,6),
            };

            foreach (var item in array)
            {
                item.GetName();
                Console.WriteLine("The surface is: {0}.",item.CalculateSurface());
            }
        }
    }
}
