using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Petrov",6),
                new Student("Parvan", "Petrov",2),
                new Student("Petkan", "Petrov",5),
                new Student("Marian", "Petrov",6),
                new Student("Geran", "Petrov",3),
                new Student("Salam", "Petrov",2),
                new Student("Gogo", "Petrov",6),
                new Student("Gosho", "Petrov",5),
                new Student("Pesho", "Petrov",1),
                new Student("Trifun", "Petrov",4),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan", "Todorov", 200, 5),
                new Worker("Gosho", "Petrov", 300, 8),
                new Worker("Bay", "Petrov", 250, 7),
                new Worker("Petar", "Petrov", 260, 8),
                new Worker("Hitar", "Petrov", 100, 5),
                new Worker("Pesho", "Ivanov", 150, 2),
                new Worker("Sasho", "Petrov", 290, 8),
                new Worker("Dido", "Petrov", 400, 8),
                new Worker("Baga", "Petrov", 600, 8),
                new Worker("Lara", "Petrov", 1000, 6),
            };

            var SortedSudents = students.OrderBy(grade => grade.Grade);
            foreach (var item in SortedSudents)
            {
                Console.WriteLine(item.Grade);
            }
            Console.WriteLine();

            var SortedWorkers = workers.OrderBy(worker => worker.MoneyPerHour());
            foreach (var item in SortedWorkers)
            {
                Console.WriteLine(item.MoneyPerHour());
            }
            Console.WriteLine();

            var mergedList = workers.Concat<Human>(students).ToList();
            var MergedList = mergedList.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            foreach (var item in MergedList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
