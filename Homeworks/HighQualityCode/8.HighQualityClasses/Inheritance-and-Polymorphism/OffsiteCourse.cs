using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    class OffsiteCourse : Course
    {
        //field
        private string town;
        
        //inherit constructor from the base class
        public OffsiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        //property
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The town cannot be null.");
                }
                this.town = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString() + string.Format("; Town = {0}", this.Town) + " }";
            return result;
        }
    }
}
