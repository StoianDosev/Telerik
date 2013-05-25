using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNameLINQ
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //The method finds all elements from the list of students which first name is before the last name alphabetically.
        public static List<Student> OrderStudents(List<Student> list)
        {
            List<Student> OrderedStudents = new List<Student>();
            foreach (Student item in list)
            {
                if ((item.FirstName.CompareTo(item.LastName)) == -1)
                {
                    OrderedStudents.Add(item);
                }
            }
            return OrderedStudents;
        }
        
    }
}
