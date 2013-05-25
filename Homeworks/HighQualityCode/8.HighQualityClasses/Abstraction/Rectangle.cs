using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        //fields
        private double width ;
        private double height;

        //constructor
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        //properties
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value of the sides cannot be 0 or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value of the sides cannot be 0 or negative.");
                }
                this.height = value;
            }
        }

        // overriden methods from the base class Figure
        public override double CalcPerimeter()
        {
            return (this.Width + this.Height) * 2;
        }

        public override double CalcSurface()
        {
            return this.Width* this.Height;
        }
    }
}
