using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    abstract class Course
    {
        //fields
        private string name;
        private string teacherName;
        private IList<string> students = new List<string>();

        //constructor
        protected Course(string name, string teaherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teaherName;
            this.Students = students;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The name cannot be null or number.");
                }
                this.name = value;

            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The teacher name cannot be null or number.");
                }
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The list of students cannot be null or number.");
                }
                this.students = value;
            }
        }

        //method which returns the list of students as a string
        protected string GetStudentsAsString()
        {
            return "{ " + string.Join(", ", this.Students) + " }";
        }

        //overriding ToString method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.Name);

            result.Append("; Teacher = ");
            result.Append(this.TeacherName);

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            result.Append(" }");
            return result.ToString();
        }

    }
}
