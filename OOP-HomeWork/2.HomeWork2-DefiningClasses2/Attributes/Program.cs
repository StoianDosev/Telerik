using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main()
        {
            Type type = typeof(SampleClass);
            object[] attribute = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in attribute)
            {
                Console.WriteLine("{0}: {1}", attr, attr.Version);
            }
        }
    }
    [Version("6.2")]
    class SampleClass
    {
    }
}
