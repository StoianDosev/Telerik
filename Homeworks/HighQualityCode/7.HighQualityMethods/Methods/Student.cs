using System;

namespace Methods
{
    class Student
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonalInformation Information { get; set; }

        //empty constructor
        public Student()
        {
        }

        //non empty constructor
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //non empty constructor
        public Student(string firstName, string lastName, PersonalInformation information)
            : this(firstName, lastName)
        {
            this.Information = information;
        }

        //method which compares two Students
        public bool IsOlderThan(Student secondStudent)
        {
            DateTime firstStudentDate = this.Information.BirthDay;
            DateTime secondStudentDate = secondStudent.Information.BirthDay;
            return firstStudentDate > secondStudentDate;
        }
    }
}
