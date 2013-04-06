using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOPPrinciplesPartOne
{
    class Disciplenes : Teacher
    {
        //fields
        private int exercises;
        private int lectures;

        //poperties
        public int Exercises
        {
            get { return this.exercises; }
            set { this.exercises = value; }
        }
        public int Lectures
        {
            get { return this.lectures; }
            set { this.lectures = value; }
        }

       //constructor
        public Disciplenes(string name, int exercises, int lectures):base(null)
        {
            base.Name = name;
            this.exercises = exercises;
            this.lectures = lectures;
        }
    }
}
