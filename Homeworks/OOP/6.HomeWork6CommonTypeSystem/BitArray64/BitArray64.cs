using System;
using System.Collections;
using System.Collections.Generic;



namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        //field
        private ulong Bits { get; set; }

        //overriding the virtual Methods from Object
        public override bool Equals(object obj)
        {
            return this.GetHashCode().Equals(obj.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.Bits.GetHashCode();
        }

        //adding index
        public int this[int index]
        {
            get
            {
                return (int)((this.Bits >> index) & 1);
            }
            set
            {

                if ((index < 0 || index >= 64))
                {
                    throw new ApplicationException(String.Format("Index {0} is invalid!", index));
                }
                if (value < 0 || value > 1)
                {
                   throw new ApplicationException( String.Format("Value {0} is invalid!", value));
                }

                //clearing position for setting
                this.Bits &= ~((ulong)(1) << index);

                // Set the bit at position index to value
                this.Bits |= ((ulong)(value)) << index;
            }
        }

        //adding operator "=="
        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return firstArray.Equals(secondArray);
        }

        //adding operator "!="
        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(firstArray.Equals(secondArray));
        }

        //implementing IEnumerable<int>
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }
        //implenting IEnumerator
        private class BitArray64Enumerator : IEnumerator
        {
            private int index = -1;
            private ulong bits;

            public BitArray64Enumerator(ulong bits)
            {
                this.bits = bits;
            }

            public object Current
            {
                get
                {
                    if (((ulong)1 << index) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }

            public bool MoveNext()
            {
                index++;
                return index < 64;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BitArray64Enumerator(this.Bits);
        }

        public override string ToString()
        {
            
            return this.Bits.ToString();
        }
    }
}
