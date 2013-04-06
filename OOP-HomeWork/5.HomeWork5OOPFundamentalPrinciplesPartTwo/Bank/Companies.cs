using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Companies : Customers
    {
        public long Bustat { get; set; }

        public Companies(string name, long bulstat)
            : base(name)
        {
            this.Bustat = bulstat;
        }


    }
}
