using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student: Human
    {
        //field
        private int grade;

        //property
        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        //constructor
        public Student(string firstName, string lastName,int grade)
        {
            this.grade = grade;
            base.FirstName = firstName;
            base.LastName = lastName;
        }
    }
}
