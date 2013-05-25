using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Point3D
{
    class Path
    {
        private List<Point3D> points; //private field with list of instances of class Point3D

        public Path()//empty constructor
        {
            this.points = new List<Point3D>();
        }

        public List<Point3D> Points// public property of the list 
        {
            get { return this.points; }
        }

        // implematation of Add function
        public void AddPoints(Point3D point)
        {
            points.Add(point);
        }

        //implementation of ToString()
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in Points)
            {
                builder.AppendFormat("{0}", item);
                builder.AppendLine();
            }

            return builder.ToString();
        }

        //implementation of operator "+" 
        public static Path operator +(Path one, Path two)
        {
            Path result = new Path();
            result.Points.AddRange(one.Points);
            result.Points.AddRange(two.Points);

            return result;
        }
    }
}
