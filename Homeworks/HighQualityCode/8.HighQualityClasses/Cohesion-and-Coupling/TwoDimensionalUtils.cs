using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    class TwoDimensionalUtils
    {
        /// <summary>
        /// Calculates distance between two points in two dimensional space.
        /// </summary>
        /// <param name="x1">First point x</param>
        /// <param name="y1">First point y</param>
        /// <param name="x2">Second point x</param>
        /// <param name="y2">Second point x</param>
        /// <returns></returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Calculates diagonal of figure in two dimensional space.
        /// </summary>
        /// <param name="firstSide">First side length.</param>
        /// <param name="secondSide">Second side length.</param>
        /// <returns>Returns the calculated diagonal as double value.</returns>
        public static double CalculateDiagonalBetweenPoints(double firstSide, double secondSide)
        {
            double distance = CalculateDistance(0, 0, firstSide, secondSide);
            return distance;
        }
    }
}
