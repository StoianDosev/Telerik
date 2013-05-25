using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape // abstract class 
    {
        // public properties
        public double Width { get; set; }
        public double Height { get; set; }

        //constructor
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // abstract methods
        public abstract double CalculateSurface();
        public abstract void GetName();
    }
}
