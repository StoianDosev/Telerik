using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    class ThreeDimensionalUtils
    {
        /// <summary>
        /// Calculates distance between two points in three dimensional space.
        /// </summary>
        /// <param name="x1">First point x coordinate</param>
        /// <param name="y1">First point y coordinate</param>
        /// <param name="z1">First point z coordinate</param>
        /// <param name="x2">Second point x coordinate</param>
        /// <param name="y2">Second point y coordinate</param>
        /// <param name="z2">Second point z coordinate</param>
        /// <returns>return distance as double value.</returns>
        public static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        /// <summary>
        /// Calculates the three dimensional diagonal of figure with width, height and depth.
        /// </summary>
        /// <param name="width">width </param>
        /// <param name="height">height</param>
        /// <param name="depth">depth</param>
        /// <returns>Returns the diagonal XYZ as double value.</returns>
        public static double CalculateDiagonal(double width, double height, double depth)
        {
            double distance = CalculateDistance(0, 0, 0, width, height, depth);
            return distance;
        }

        /// <summary>
        /// Calculates the valume of the three dimensional figure
        /// </summary>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <param name="depth">depth</param>
        /// <returns>Returns the valume of the figure as double value.</returns>
        public static double CalculateVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }
    }
}
