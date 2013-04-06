using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point3D
{
    static class PathStorage
    {
        //private static fields
        private static Path path = new Path();
        private static Path currentPath = new Path();

        public static Path Path// public property only for path field
        {
            get { return path; }
            
        }
        //implementation of the function which write on the text file
        public static void WritePaths(Path Path)
        {
            StreamWriter writer = new StreamWriter(@"../../Saves.txt");
            using (writer)
            {
                Path sum = new Path();
                sum = Path + currentPath;// using operator "+" for instances from the Path class
                writer.WriteLine(sum);
                currentPath.Points.AddRange(Path.Points);//ensuring that when we add new content the previous one will remain
            }
        }
        //implenatation of the function which read from the text file
        public static Path LoadPaths()
        {
            StreamReader reader = new StreamReader(@"../../Saves.txt");
            Path result = new Path();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null && line !="")
                {
                    Point3D point = new Point3D();
                    char[] tokens = { ' ', ',', ';', '.' };
                    string[] array = line.Split(tokens, StringSplitOptions.RemoveEmptyEntries);
                    if (array.Length == 3)// every instnce Point3D has x,y,z proparties
                    {
                        point.x = int.Parse(array[0]);
                        point.y = int.Parse(array[1]);
                        point.z = int.Parse(array[2]);

                        line = reader.ReadLine();
                        result.AddPoints(point);// Adding every "point" to inctnce "result" of class Path
                    }
                    
                }
            }
            return result;
        }
    }
}
