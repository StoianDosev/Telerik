using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionIEnumerableT
{
    public static class Extensions
    {
        //Extension method for Sum()
        public static T Sum<T>(this IEnumerable<T> elements)
        {
            dynamic sum = default(T);
            foreach (var item in elements)
            {
                sum += item;
            }
            return sum;
        }
        //Extension method for Product()
        public static T Product<T>(this IEnumerable<T> elements)    

        {
            dynamic product = 1;
            foreach (var item in elements)
            {
                product *= item;
            }

            return product;
        }
        //Extension method for Min() 
        public static T Min<T>(this IEnumerable<T> elements)
        {

            dynamic min = int.MaxValue;

            foreach (var item in elements)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }
        //Extension method for Max()
        public static T Max<T>(this IEnumerable<T> elements)
        {
            dynamic max = int.MinValue;
            foreach (var item in elements)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }
        //Extension method for Avarage()
        public static T Avarage<T>(this IEnumerable<T> elements)
        {
            dynamic avr = default(T);
            int count =0;
            foreach (var item in elements)
            {
                avr += item;
                count++;
            }
            return avr / count; 
        }
    }
}
