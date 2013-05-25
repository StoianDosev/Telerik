using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.*/



namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit companyDeposit = new Deposit(new Companies("SpaceX", 123), 3, 8m, 999m);
            Console.WriteLine("The inerest for {0} is: {1}% for the period of {2} months.",companyDeposit.Company.Name, companyDeposit.CalculateInterests(), companyDeposit.NumberOfMonths);
            
            Loan individual = new Loan((new Individuals("Elon Musk", 9876)), 2, 8m, 1000m);
            Loan company = new Loan((new Companies("TeslaMotors", 123)), 4, 8m, 1000m);
            
            Console.WriteLine("The inerest for {0} is: {1}% for the period of {2} months.",individual.Customer.Name, individual.CalculateInterests(),individual.NumberOfMonths);
            Console.WriteLine("The inerest for {0} is: {1}% for the period of {2} months.", company.Company.Name, company.CalculateInterests(), company.NumberOfMonths);

           
        }
    }
}
