using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 4. Create a class Person with two fields – name and age. Age can be left unspecified 
 (may contain null value. Override ToString() to display the information of a person 
 and if age is not specified – to say so. Write a program to test this functionality.*/
namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bill", 21);
            Person person = new Person();
            Console.WriteLine(person1);
            Console.WriteLine(person);

            
        }
    }
}
