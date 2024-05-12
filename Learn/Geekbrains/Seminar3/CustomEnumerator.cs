using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class CustomEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = -1;

        object IEnumerator.Current => -1;

        public void Dispose()
        {
            Current = -1;
        }

        public bool MoveNext()
        {
            Current++;
            if (Current <= 10)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Current = -1;
        }
    }
}
