using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int currentTurns;
        public int LifeTime { get; set; }
        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime)
            : base(topLeft, body)
        {
            this.currentTurns = 0;

            this.LifeTime = lifetime;
        }

        public override void Update()
        {
            this.currentTurns++;
            if (this.currentTurns > this.LifeTime)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
