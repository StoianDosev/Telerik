using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Define a class Student, which contains data about a student – first, middle and last name, SSN, 
 permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
 for the specialties, universities and faculties. Override the standard methods, inherited by  
 System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 
 2.  Add implementations of the ICloneable interface. The Clone() method should deeply copy
 all object's fields into a new object of type Student.
 * 
 3.  Implement the  IComparable<Student> interface to compare students by names (as first criteria, 
 in lexicographic order) and by social security number (as second criteria, in increasing order). */


namespace DefineStudent
{
    class Program
    {
        static void Main(string[] args)
        {  
            Student student = new Student("Pesho", "Petrov", "Ivanov", 912343, "Bul. Bulgaria #1", 882434, "pesho@pesho.com", Specialities.Low, Universities.NewBulgarianUniversity, Faculties.FacultyOfEconomics);
            Student student2 = new Student();
            Student student3 = new Student();
            Console.WriteLine(student3);
            student2.Speciality = Specialities.Informatics;
           
            bool a = student2.Equals(student);

            Console.WriteLine(student2 != student);
            Console.WriteLine(student2== student);

            student2 = student.Clone();
            student2.Faculty = Faculties.FacultyOfHistory;
            Console.WriteLine(student);
            Console.WriteLine(student2);
            Console.WriteLine(student2.CompareTo(student));
           
        }
    }
}
