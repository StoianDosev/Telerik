using System;

namespace FigureRotation
{
    //1.Refactor the following code to use proper variable naming and simplified expressions:

    class RotateFigure
    {
        static void Main()
        {
            Figure figure = new Figure(12, 2);
            Console.WriteLine(figure.Width);
        }

        public static Figure GetFigureRoteded(Figure figure, double angleInRadians)
        {
            double cosWidth = Math.Abs(Math.Cos(angleInRadians)) * figure.Width;
            double sinWidth = Math.Abs(Math.Sin(angleInRadians)) * figure.Width;
            double finalWidth = cosWidth + sinWidth;

            double cosHeight = Math.Abs(Math.Cos(angleInRadians)) * figure.Height;
            double sinHeight = Math.Abs(Math.Sin(angleInRadians)) * figure.Height;
            double finalHeight = cosHeight + sinHeight;

            Figure rotatedFigure = new Figure(finalWidth, finalHeight);
            return rotatedFigure;
        }
    }
}
