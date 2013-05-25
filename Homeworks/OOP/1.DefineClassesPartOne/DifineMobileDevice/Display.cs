using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifineMobileDevice
{
    class Display
    {
        // Pivate fields of the class
        private double size;
        private int colors;

        public Display(): this(0, 0) // empty constructor
        {
        }

        public Display(int colors, double size)// non-empty costructor with verifiaction of the input.
        {
            IsColorsCorrect(colors);
            this.colors = colors;
            IsSizeCorrect(size);
            this.size = size;
        }


        // public properties 
        public double Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }
        public int Colors
        {
            get { return this.colors; }
            private set { this.colors = value; }

        }
        public override string ToString() // Overriding ToString.
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("The size of the display is: {0} with {1} colors.", size, colors);

            return builder.ToString();
        }

        // Creating methods to verify that the input is correct.
        private void IsSizeCorrect(double input)
        {
            if (input < 1)
            {
                throw new ArgumentOutOfRangeException("The size cannot be smaller than 1 inch.");
            }
        }
        private void IsColorsCorrect(int input)
        {
            if (input < 10)
            {
                throw new ArgumentOutOfRangeException("The colors cannot be below 10.");
            }
        }
    }
}
