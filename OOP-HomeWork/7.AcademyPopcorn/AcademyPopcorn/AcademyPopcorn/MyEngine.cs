using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MyEngine : Engine
    {
        public MyEngine(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface) 
        { }
        
        public void ShootPlayerRacker()
        { }
    }
}