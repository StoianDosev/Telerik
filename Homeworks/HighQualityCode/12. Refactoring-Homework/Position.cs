using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFifteen
{
    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public void Update(int directionX, int directionY)
        {
            this.Row += directionX;
            this.Col += directionY;
        }
    }
}
