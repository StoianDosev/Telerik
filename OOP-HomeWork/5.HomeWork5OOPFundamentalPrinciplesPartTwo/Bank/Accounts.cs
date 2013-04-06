using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Accounts
    {

        // publis properties
        public int NumberOfMonths { get; set; }
        public decimal InterestRate { get; set; }
        public Customers Customer { get; set; }
        public decimal Balance { get; set; }

        // constructor
        public Accounts(Customers customer, int months, decimal interestRate, decimal balance)
        {
            this.NumberOfMonths = months;
            this.InterestRate = interestRate;
            this.Customer = customer;
            this.Balance = balance;
        }

        // virtual method
        public virtual decimal CalculateInterests()
        {
            return this.InterestRate * this.NumberOfMonths;
        }
        
    }
}
