using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Bits : IBits
    {
        private readonly int size = 0;
        public long Value { get; private set; } = 0;

        public bool GetBit(int index)
        {
            return this[index];
        }

        public void SetBit(int index, bool value)
        {
            this[index] = value;
        }

        public Bits(long value)
        {
            this.Value = value;
            this.size = sizeof(long);
        }

        public bool this[int index]
        {
            get
            {
                if (index > size || index < 0)
                    return false;
                return ((Value >> index) & 1) == 1;
            }
            set
            {
                if (index > size || index < 0)
                    return;
                if (value == true)
                    Value = (long)(Value | (1 << index));
                else
                {
                    var mask = (long)(1 << index);
                    mask = ~mask;
                    Value &= (long)(Value & mask);
                }
            }
        }

        public static explicit operator long(Bits b) => (long)b.Value;
        public static implicit operator Bits(long b) => new Bits(b);
        public static implicit operator Bits(int b) => new Bits(b);
        public static implicit operator Bits(byte b) => new Bits(b);
    }
}