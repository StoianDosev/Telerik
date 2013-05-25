using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineException
{

    //class which implements the Exception class
    class InvalidRangeException<T> : Exception
    {
        //properties
        public T Start { get; set; }
        public T End { get; set; }

        // constructor uses the the base constructor
        public InvalidRangeException(T start, T end, string message) : base(message)
        {
            this.Start = start;
            this.End = end;
            
        }
    }
}
