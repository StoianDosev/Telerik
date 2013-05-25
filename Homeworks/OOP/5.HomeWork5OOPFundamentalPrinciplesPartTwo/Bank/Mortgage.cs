using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Mortgage : Accounts, IDepositer
    {
        //properies
        public Individuals Individual { get; set; }
        public Companies Company { get; set; }

        // constructor for individual accounts
        public Mortgage(Individuals individual, int months, decimal interestRate, decimal balance)
            : base(individual, months, interestRate, balance)
        {
            this.Individual = individual;
        }

        // constructor for company accounts
        public Mortgage(Companies company, int months, decimal interestRate, decimal balance)
            : base(company, months, interestRate, balance)
        {
            this.Company = company;
        }

        //method from the interface IDepositer
        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        // overriding the virtual base method
        public override decimal CalculateInterests()
        {
            if (Individual != null && NumberOfMonths <= 6)
            {
                return 0;
            }
            else if (Individual != null && NumberOfMonths > 6)
            {
                return this.InterestRate * (this.NumberOfMonths - 6);
            }
            else if( Company != null && NumberOfMonths <= 12)
            {
                return this.InterestRate / 2 * this.NumberOfMonths;
            }
            else
            {
                return base.CalculateInterests();
            }
        }
    }
}
