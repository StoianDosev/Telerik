using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Shape
    {
        ////constructor implements the base construtor 
        public Circle(double r)
            : base(r, r)
        {
        }

        // overriding the abstarct methods from base class Shape
        public override double CalculateSurface()
        {
            return base.Width * base.Width * Math.PI;
        }

        public override void GetName()
        {
            Console.WriteLine("The figure is circle.");
        }
    }
}
