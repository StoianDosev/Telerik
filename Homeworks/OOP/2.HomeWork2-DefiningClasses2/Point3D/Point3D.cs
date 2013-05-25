using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        //public properties 
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);// private static field for zero point

        public static Point3D ZeroPoint//public static property for zero point
        {
            get { return zeroPoint; }
        }

        public Point3D(int x, int y, int z)//non-empty constructor
            : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()//overriding Tostring()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0}, {1}, {2}.", x, y, z);
            
            return builder.ToString();
        }

    }
}
