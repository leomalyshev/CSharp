using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    public interface ICalc
    {
        public void Add(double number);

        public void Subtract(double number);

        public void Divide(double number);

        public void Multiply(double number);

        void CancelLast();

        event EventHandler<OperandChangedEventArgs> GotResult;
    }

}
