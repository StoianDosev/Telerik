using System;
using System.Linq;

/*2. Refactor the following examples to produce code with well-named C# identifiers:*/

namespace CodeRefactoring
{
    public enum Gender
    {
        Male, Female,
    }
    class Human
    {
        //public properties
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        //constuctor
        public Human(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //empty constructor
        public Human()
            : this("unknown", 0, Gender.Male)
        {
        }

        public void ProduceHuman(int humanAge)
        {
            Human person = new Human();
            person.Age = humanAge;

            if (humanAge % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Female;
            }
        }
    }
}
