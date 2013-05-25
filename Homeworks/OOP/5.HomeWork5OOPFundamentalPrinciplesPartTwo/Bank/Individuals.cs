using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Individuals : Customers
    {
        //property
        public long ID { get; set; }

        //constructor 
        public Individuals(string name, long id)
            : base(name)
        {
            this.ID = id;
        }

    }
}
