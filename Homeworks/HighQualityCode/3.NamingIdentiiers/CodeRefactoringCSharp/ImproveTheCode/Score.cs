using System;
using System.Linq;

namespace Minesweeper
{
    public class Score
    {
        //fields
        private string name;
        private int points;

        //empty constructor
        public Score():this("unknown",0)
        {
        }

        //constructor
        public Score(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
