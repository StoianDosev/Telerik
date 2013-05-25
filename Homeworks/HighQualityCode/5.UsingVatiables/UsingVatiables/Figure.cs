using System;

namespace FigureRotation
{
    class Figure
    {
        //private fields
        private double width;
        private double height;

        //constructor
        public Figure(double width, double heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        //public properties
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of the width should be non negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of the height should be non negative.");
                }
                this.height = value;
            }
        }
    }
}
