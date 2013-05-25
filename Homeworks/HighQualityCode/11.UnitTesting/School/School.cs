using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        //field
        private string name;

        //constructor
        public School(string name)
        {
            this.Name = name;
        }

        //property
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null or empty value.");
                }
                this.name = value;
            }
        }

    }
}
