using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Generic<T>
        where T : IComparable<T> // restriction that all of T type has to implement this interface;
    {
        public const int capacity = 10;// constant capacity of of the array
        private T[] list;
        private int usedPositions;// using that field to hold how many positions we are using.

        public Generic()// empty constructor
            : this(capacity)
        {
        }

        public Generic(int number)//non-empty constructor
        {
            if (number > 0)// confirming that we cannot create negative capacity
            {
                this.list = new T[number];
                usedPositions = 0;
            }
            else
            {
                throw new IndexOutOfRangeException("Out of range!");
            }
        }

        //implementation of Add function
        public void AddElement(T element)
        {
            if (usedPositions < this.list.Length)
            {
                this.list[usedPositions] = element;
                usedPositions++;
            }
            else
            {
                T[] newList = new T[2 * this.list.Length];// if the we exceed the capacity it doubles the size of the array

                for (int i = 0; i < usedPositions; i++)
                {
                    newList[i] = this.list[i];
                }
                newList[usedPositions] = element;
                this.list = newList;
                usedPositions++;
            }
        }
        //implemantation of the Access function
        public T AccessElementByIndex(int n)
        {
            if (n < usedPositions)
            {
                T element = this.list[n];
                return element;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        //Implementation of the Remove function
        public void RemoveElementByIndex(int n)
        {
            T element = this.list[n];
            if (n > usedPositions && n < 0)// confirming that we can remove element only that we have
            {
                throw new ArgumentOutOfRangeException("Out of range! Please enter a valid position.");
            }
            else
            {
                for (int i = n; i < this.usedPositions - 1; i++)
                {
                    this.list[i] = this.list[i + 1];
                }
                this.list[this.usedPositions - 1] = default(T);
                this.usedPositions--;
            }
        }

        //implementation of the Insert function
        public void InsertElementOnPosition(T element, int index)
        {
            if (index < 0 || index > usedPositions)// confirm that we can insert elements only with proper indexes.
            {
                throw new ArgumentOutOfRangeException("Out of range!Please enter a valid position.");
            }
            else
            {
                int q = 0;
                usedPositions++;
                T[] newList = new T[1 + this.list.Length];// before the insert opration we make the lenght bigger

                for (int i = 0; i < usedPositions; i++)
                {
                    if (i == index)
                    {
                        newList[index] = element;
                        q = 1;
                        newList[i + q] = this.list[i];
                    }
                    else if (i < list.Length && i != index)
                    {
                        newList[i + q] = this.list[i];
                    }
                }
                this.list = newList;
            }
        }

        public void Clear()// implementation of Clear function
        {
            this.list = new T[capacity];
            usedPositions = 0;
        }

        public int FindElement(T element)//Implementation of Find function
        {
            T result = default(T);
            int index = 0;
            for (int i = 0; i < usedPositions; i++)
            {
                if (this.list[i].Equals(element))
                {
                    result = this.list[i];
                    index = i;
                }
            }
            dynamic obj = result;
            if( obj == default(T))
            {
                throw new ArgumentException("No such element!");
            }
            return index;
        }

        public override string ToString() // Overriding ToString() function
        {
            StringBuilder builder = new StringBuilder();

            if (usedPositions > 0)
            {
                for (int i = 0; i < usedPositions; i++)
                {
                    builder.AppendFormat("{0},", this.list[i]);
                }
            }

            return builder.ToString();
        }

        //implementation of the Min and Max functions
        public T Min()
        {
            T min = list[0];
            for (int i = 0; i < usedPositions; i++)
            {
                
                if ((list[i].CompareTo(min)) < 0)//using CompareTo
                {
                    min = list[i];
                }
            }
            return min;
        }
        public T Max()
        {
            T max = default(T);// using the default value of each type element
            for (int i = 0; i < usedPositions; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
