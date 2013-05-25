using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    //4.Redesign the classes and refactor the code from the solution "Inheritance-and-Polymorphism" to follow
    // the best practices in high-quality classes. Extract abstract base class and move all common properties in it.
    //Encapsulate the fields and make sure required fields are not left without a value. Reuse the repeating code though base methods.

    class CoursesExamples
    {
        static void Main()
        {
            IList<string> students = new List<string>(){ "Thomas", "Ani", "Steve","Peter", "Maria" };
            LocalCourse localCourse = new LocalCourse("Pesho", "Mitio", students, "Light");
            Console.WriteLine(localCourse);
            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev", 
                new List<string>() { "Thomas", "Ani", "Steve" },"Varna");
            Console.WriteLine(offsiteCourse);

           
        }
    }
}
