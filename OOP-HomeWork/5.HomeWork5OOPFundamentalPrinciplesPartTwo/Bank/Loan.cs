using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Loan : Accounts, IDepositer
    {
        //properies
        public Individuals Individual { get; set; }
        public Companies Company { get; set; }

        // constructor for individual accounts
        public Loan(Individuals individual, int months, decimal interestRate, decimal balance)
            : base(individual, months, interestRate, balance)
        {
            this.Individual = individual;
        }

        // constructor for company accounts
        public Loan(Companies company, int months, decimal interestRate, decimal balance)
            : base(company, months, interestRate, balance)
        {
            this.Company = company;
        }

        //method from  the interface IDepositer
        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        // overriding the virtual base method
        public override decimal CalculateInterests()
        {
            if (this.Individual != null && NumberOfMonths <= 3)
            {
                return 0;
            }
            else if (this.Individual != null && NumberOfMonths > 3)
            {
                return this.InterestRate * (base.NumberOfMonths - 3);
            }
            else if (this.Company != null && NumberOfMonths <= 2)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * (base.NumberOfMonths - 2);
            }
        }
    }
}
