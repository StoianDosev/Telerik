using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNameLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> { 
                new Student{ FirstName = "Alexandre", LastName = "Dumas", Age = 15},
                new Student{ FirstName = "Nicolaus", LastName = "Copernicus", Age = 24},
                new Student{ FirstName = "René", LastName = "Descartes", Age = 18},
                new Student{ FirstName = "BenFranklin", LastName = "Franklin", Age = 25},
            };

            
            //Conventional static method that finds all elements from the list of students which first name is before the last name alphabetically
            Console.WriteLine("Conventional method:");
            List<Student> stud = new List<Student>();
            stud.AddRange(Student.OrderStudents(students)); 

            foreach (var item in stud)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
           
            //LINQ method that finds all elements from the list of students which first name is before the last name alphabetically.
            Console.WriteLine("LINQ method:");
            var LINQStudents = from names in students
                               where names.FirstName.CompareTo(names.LastName) == -1
                               select names;

            foreach (Student item in LINQStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
            

            //LINQ method  for selection  all elements with property "Age" in the range of 18-24
            Console.WriteLine("LINQ method:");
            var studentsLINQ = from age in students
                               where age.Age >= 18 && age.Age <= 24
                               select age;

            foreach (Student item in studentsLINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
            

            //LINQ method for sorting the students by first name and last name in descending order
            Console.WriteLine("LINQ method:");
            var NewStudentsLINQ = from name in students
                                  orderby name.FirstName descending, name.LastName descending
                                  select name;
            foreach (Student item in NewStudentsLINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
            

            // Lambda method that finds all elements from the list of students which first name is before the last name alphabetically.
            Console.WriteLine("Lambda method:");
            List<Student> LambdaStudents = students.FindAll(Name => (Name.FirstName.CompareTo(Name.LastName) == -1));

            foreach (Student item in LambdaStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
           

            //Lambda method for selection all elements with property "Age" in the range of 18-24
            Console.WriteLine("Lambda method:");
            List<Student> StudentsLambda = students.FindAll( age => ( age.Age >= 18 && age.Age <= 24));

            foreach (Student item in StudentsLambda)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
            

            //LINQ method for sorting the students by first name and last name in descending order
            Console.WriteLine("Lambda method:");
            var NewStudentsLambda = students.OrderByDescending(name => name.FirstName).ThenByDescending(name => name.LastName);

            foreach (var item in NewStudentsLambda)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();
        }
    }
}
