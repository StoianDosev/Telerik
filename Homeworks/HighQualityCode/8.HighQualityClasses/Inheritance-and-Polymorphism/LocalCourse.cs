using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    class LocalCourse : Course
    {
        //field
        private string lab;

        //inherit constructor from the base class
        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        //property
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The lab cannot be null.");
                }
                this.lab = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString() + string.Format("; Lab = {0}", this.Lab) + " }";
            return result;
        }
    }
}
