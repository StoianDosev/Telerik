using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineStudent
{
    //enums
    public enum Specialities  
    {
         Economy, History, Informatics, Low, BisnessAdministration,
    }
    public enum Universities
    {
        SofiaUniversity, NewBulgarianUniversity, TechnicalUniversity,
    }
    public enum Faculties
    {
        FacultyOfEconomics, FacultyOfHistory, FacultyOfLaw, FacultyOfMathemathics
    }

    class Student : ICloneable, IComparable<Student>
    {
        // fields
        private string firstName;
        private string secondName;
        private string lastName;
        private int ssn;
        private string address;
        private long mobilePhone;
        private string email;
        private Specialities speciality;
        private Universities univeristy;
        private Faculties faculty;

        //empty constructor
        public Student()
        {
        }
        //non-empty constructor
        public Student(string firstName, string secondName, string lastName, int ssn, string address, long mobilePhone, string email, Specialities speciality, Universities univeristy, Faculties faculty)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.address = address;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.speciality = speciality;
            this.univeristy = univeristy;
            this.faculty = faculty;
        }

        // public properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public long MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public Specialities Speciality
        {
            get
            {
                return this.speciality;
            }
            set
            {
                this.speciality = value;
            }
        }

        public Universities Univeristy
        {
            get
            {
                return this.univeristy;
            }
            set
            {
                this.univeristy = value;
            }
        }

        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        //overriding the Object virutal methods
        public override bool Equals(object st)
        {
            Student student = st as Student;
            if (student == null)
            {
                return false;
            }
            if (this.FirstName != student.FirstName)
            {
                return false;
            }
            if (this.LastName != student.LastName)
            {
                return false;
            }
            if( !Object.Equals(this.SecondName,student.SecondName))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} , {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", this.FirstName ?? "<empty>", this.SecondName ?? "<empty>", this.LastName ?? "<empty>", (this.SSN > 0) ? this.SSN.ToString() : "<empty>", this.Address ?? "<empty>", (this.MobilePhone > 0) ? this.MobilePhone.ToString() : "<empty>", this.Email ?? "<empty>", this.Speciality, this.Univeristy, this.Faculty);
            return builder.ToString();
        }
        public override int GetHashCode()
        {
            return Speciality.GetHashCode() ^ Univeristy.GetHashCode() ^ Faculty.GetHashCode() ^ FirstName.GetHashCode() ^ SecondName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode() ^ Address.GetHashCode() ^ MobilePhone.GetHashCode() ^ Email.GetHashCode();
        }

        // adding operator "=="
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        //adding operator "!="
        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }

        //implementing IClonable
        public Student Clone()
        {
            Student studentNew = new Student(this.FirstName, this.SecondName, this.LastName, this.SSN , this.Address, this.MobilePhone, this.Email, this.Speciality, this.Univeristy, this.Faculty);

            return studentNew;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        //implementing ICompareble<Student>
        public int CompareTo(Student st)
        {
            if (this.FirstName.CompareTo(st.FirstName) != 0)
            {
                return this.FirstName.CompareTo(st.FirstName);
            }
            else if (this.SecondName.CompareTo(st.SecondName) != 0)
            {
                return this.SecondName.CompareTo(st.SecondName);
            }
            else if (this.LastName.CompareTo(st.LastName) != 0)
            {
                return this.LastName.CompareTo(st.LastName);
            }
            else if (this.SSN.CompareTo(st.SSN) != 0)
            {
                return this.SSN.CompareTo(st.SSN);
            }
            return 0;
        }
    }
}
