using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Seminar3
{
    public class Calculator : ICalc
    {
        private Stack<double> stack = new Stack<double>();
        public double Result
        {
            get
            {
                return stack.Count == 0 ? 0 : stack.Peek();
            }
            set
            {
                stack.Push(value);
                RaiseResult();
            }
        }

        public event EventHandler<OperandChangedEventArgs> GotResult;

        public void RaiseResult()
        {
            GotResult.Invoke(this, new OperandChangedEventArgs(stack.Peek()));
        }

        public void Add(double number)
        {
            Result += number;
        }

        public void Divide(double number)
        {
            Result /= number;
        }

        public void Multiply(double number)
        {
            Result *= number;
        }

        public void Subtract(double number)
        {
            Result -= number;
        }

        public void CancelLast()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseResult();
            }
            
        }
    }
}
