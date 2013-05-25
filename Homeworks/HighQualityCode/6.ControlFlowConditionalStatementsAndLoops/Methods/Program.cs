using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            Potato potato = new Potato();

            //... 

            if (potato != null)
            {
                if (potato.isPeeled && potato.isFresh)
                {
                    Cook(potato);
                }
                else
                {
                    throw new NotImplementedException();    
                }
            }
            else
            {
                throw new NotImplementedException();
            }

            //...

            int MIN_X = -100;
            int MAX_X = 100;
            int x = 0;
            bool isInRangeX = x >= MIN_X && x <= MAX_X;

            int MIN_Y = -200;
            int MAX_Y = 200;
            int y = 1;
            bool isInRangeY = y >= MIN_Y && y <= MAX_Y;

            bool isVisited = false;

            //....

            if (isInRangeX && isInRangeY && !isVisited)
            {
                VisitCell();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
  
        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
