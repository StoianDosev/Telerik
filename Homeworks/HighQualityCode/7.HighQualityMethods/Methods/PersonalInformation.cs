using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class PersonalInformation
    {
        //properties
        public DateTime BirthDay { get; private set; }
        public string Interests { get; private set; }
        public string City { get; private set; }

        //constructors
        public PersonalInformation(string birthDay, string city)
        {
            DateTime birthDate;
            bool isValidDate = DateTime.TryParse(birthDay, out birthDate);
            if (isValidDate)
            {
                this.BirthDay = birthDate;
            }
            else
            {
                throw new FormatException("Incorrect DateTime format!");
            }

            this.City = city;
        }

        public PersonalInformation(string birthDay, string interests, string city)
            : this(birthDay,city)
        {
            this.Interests = interests;
        }
    }
}
