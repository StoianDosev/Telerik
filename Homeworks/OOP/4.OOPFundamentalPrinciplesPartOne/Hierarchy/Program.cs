using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Tomcat t = new Tomcat(12,"tom");
            Kitten k = new Kitten(24,"maca");

            t.ProduceSoun();
            k.ProduceSoun();
            Console.WriteLine(k.Sex);

            Cat[] cats = 
            {
                new Kitten( 1, "Maca"),                
                new Kitten( 6, "Macata"),
                new Tomcat( 5, "Tom"),
                new Tomcat( 2, "Hamish"),
            };
            Dog[] dogs =
            {
                new Dog( 6, "Dogy", "male"),
                new Dog( 7, "Dino", "female"),
                new Dog( 8, "Dobcho", "male"),
                new Dog( 1, "Bobcho", "male")
            };
            Frog[] frogs =
            {
                new Frog( 1, "Jabcho", "male"),
                new Frog( 2, "Jabok", "male"),
                new Frog( 7, "Jaborana", "female"),
                new Frog( 6, "Jaba", "female")
            };

            dogs[0].ProduceSoun();
            frogs[1].ProduceSoun();
            cats[2].ProduceSoun();

            Console.WriteLine("The average age of the dogs is " + Animals.Average(dogs));
            Console.WriteLine("The average age of the frogs is " + Animals.Average(frogs));
            Console.WriteLine("The average age of the cats is " + Animals.Average(cats));

        }
    }
}
