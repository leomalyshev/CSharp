using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Task2_4
    {
        static void Main2_4(string[] args)
        {
            string info = "Эта строка содержит числа 12345 в своей середине";

            StringBuilder sb = new StringBuilder();

            bool check = false;

            for (int i = 0; i < info.Length; i++)
            {
                if (char.IsDigit(info[i]))
                {
                    check = true;
                }

                if (check) sb.Append(info[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
