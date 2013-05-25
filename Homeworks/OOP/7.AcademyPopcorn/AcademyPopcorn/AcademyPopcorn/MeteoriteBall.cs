using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed) 
        {
        }

        public override void Update()
        {
            base.Update();
            this.ProduceObjects();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            TrailObject to = new TrailObject(this.TopLeft, new char[,] { { 'x' } }, 3);
            List<TrailObject> result = new List<TrailObject>();
            result.Add(to);
            return result;
        }
    }
}