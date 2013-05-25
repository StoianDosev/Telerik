using System;

namespace Abstraction
{
    class Circle : Figure
    {
        //field
        private double radius;

        //constructor
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        //property
        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The radius cannot be 0 or negative number.");
                }
                this.radius = value;
            }
        }
        
        //overriden methods from the base class Figure
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
