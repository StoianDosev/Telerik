using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllNumbersDevidedOnSevenAndThree
{
    static class Extensions
    {
        //Extension method for Generic type
        public static List<T> DevidedOnSevenAndThree<T>(this List<T> array )
        {
            List<T> newArr = new List<T>();
            
            foreach ( dynamic item in array)
            {
                if (item % 21 == 0)
                {
                    newArr.Add(item);
                }
            }
            return newArr;
        }

        // Extension method for type array
        public static int[] DevidedOnSevenAndThreeArray(this int[] array)
        {
            List<int> current = new List<int>();
            foreach (int item in array)
            {
                if (item % 21 == 0)
                {
                    current.Add(item);
                }
                
            }
            if (current.Count == 0)
            {
                throw new ArgumentOutOfRangeException();// if we don't have elemnts according to condition we throw exception
            }

            int[] newArray = new int[current.Count];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = current[i];
            }
            return newArray;
        }
    }
}
