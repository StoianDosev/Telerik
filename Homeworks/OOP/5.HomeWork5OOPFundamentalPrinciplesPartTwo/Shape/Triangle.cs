using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : Shape
    {
        //constructor implements the base construtor
        public Triangle(double width, double height) : base(width,height) 
        {
        }

        // overriding the abstarct methods from base class Shape
        public override double CalculateSurface()
        {
            return base.Height * base.Width / 2;
        }

        public override void GetName()
        {
            Console.WriteLine("The figure is triangle.");
        }
    }
}
