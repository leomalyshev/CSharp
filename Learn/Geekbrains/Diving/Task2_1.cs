using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Task2_1
    {
        static void Main2_1(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 1000; i+=3)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
