using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            StringBuilder n = new StringBuilder();
            s.Append("809808fdjs");
            n.Append( s.Substring(1, 5));
            
            Console.WriteLine(n);
        }
    }
}
