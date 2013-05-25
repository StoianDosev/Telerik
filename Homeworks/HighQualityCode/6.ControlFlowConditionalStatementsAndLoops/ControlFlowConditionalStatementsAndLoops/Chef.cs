using System;
using System.Linq;

namespace ControlFlowConditionalStatementsAndLoops
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }
        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }
        private void Cut(Vegetable vegatable)
        {
            throw new NotImplementedException();
        }
        private void Peel(Vegetable vegatable)
        {
            throw new NotImplementedException();
        }
        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }
        
    }
}
