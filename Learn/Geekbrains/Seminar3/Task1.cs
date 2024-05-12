using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Task1
    {
        static void Main1(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };

            Stack<int> stack = new Stack<int>();

            List<int> ints2 = new List<int>();

            foreach (var i in ints) stack.Push(i);

            while (stack.Count > 0) ints2.Add(stack.Pop());

            ints2.ForEach(Console.WriteLine);

        }
    }
}
