using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Worker : Human
    {
        //fields
        private double weekSalary;
        private int workHoursPerDay;

        //properies
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        //constructor
        public Worker( string firstName,string lastName, double weekSalary, int workHoursPerDay)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        //method
        public double MoneyPerHour()
        {
            double result = 0;
            int workDays = 5;
            return result = this.weekSalary / workDays / this.workHoursPerDay;
        }
    }
}
