using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Task2_2
    {
        static void Main2_2(string[] args)
        {
            Console.WriteLine("Введите число");
            byte num = Convert.ToByte(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 1)
                {
                    count++;
                }
                num /= 2;
            }

            Console.WriteLine(count);
        }
    }
}
