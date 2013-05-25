using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course : School
    {
        //fields
        public readonly int MaxStudentsCount = 29;
        private IList<Student> students;

        //constructor
        public Course(string name, IList<Student> student):base(name)
        {
            this.Students = student;
        }

        //property
        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The course cannot exists without students.");
                }
                this.students = value;
            }
        }

        //method for adding students
        public void AddNewStudentsToCourse(Student newStudent)
        {
            bool isCorrectNumber = IsStudentHasSameNumber(newStudent);

            if (isCorrectNumber)
            {
                throw new ArgumentException();
            }
            this.students.Add(newStudent);

            if (students.Count > MaxStudentsCount)
            {
                throw new ArgumentOutOfRangeException("The max number of students in each course can be 30.");
            }
        }
        //method for removing students
        public void UnsignStudentFromCourse(Student unsignedStudent)
        {
            bool isNumberFound = IsStudentHasSameNumber(unsignedStudent);
            bool isNameFound = IsStudentHasSameName(unsignedStudent);
            if (isNameFound && isNumberFound)
            {
                this.students.Remove(unsignedStudent);
            }
            else
            {
                throw new ArgumentException("The student is not signed for this course.");
            }
        }
        
        public bool IsStudentHasSameName(Student seekedStudent)
        {
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Name == seekedStudent.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsStudentHasSameNumber(Student seekedStudent)
        {
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Number == seekedStudent.Number )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
