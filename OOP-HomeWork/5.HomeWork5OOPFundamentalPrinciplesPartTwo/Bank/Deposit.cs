using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit : Accounts, IWithdrawer, IDepositer
    {
        // public properties
        public Individuals Individual { get; set; }
        public Companies Company { get; set; }

        // constructor for individual accounts
        public Deposit(Individuals individual, int months, decimal interestRate, decimal balance)
            : base(individual, months, interestRate, balance)
        {
            this.Individual = individual;
        }

        // constructor for company accounts
        public Deposit(Companies company, int months, decimal interestRate, decimal balance)
            : base(company, months, interestRate, balance)
        {
            this.Company = company;
        }

        // method from the interface IWithdrawer
        public void WithdrawMoney(decimal money)
        {
            base.Balance -= money;
        }

        //method from  the interface IDepositer
        public void DepositMoney(decimal money)
        {
            base.Balance += money;
        }

        // overriding the virtual base method
        public override decimal CalculateInterests()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterests();
            }
        }

    }
}
