using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    public class CalculatorActionLog
    {
        private Stack<(double, string)> logger = new Stack<(double, string)>();

        public void AddLog(double number, string operation)
        {
            logger.Push(new (number,operation));
        }

        public string GetLog()
        {
            var tuple = logger.Peek();
            
            StringBuilder sb = new StringBuilder();

            foreach (var item in logger)
            {
                sb.Append(tuple.Item1 + " " + tuple.Item2);
            }
            
            return sb.ToString();
        }
    }
}
