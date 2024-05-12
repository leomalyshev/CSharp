using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Task2_6
    {
        static void Main2_6(string[] args)
        {
            string info = "Эта ст1рока не долж2на содерж345ать цифры67";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < info.Length; i++)
            {
                if (!char.IsDigit(info[i]))
                {
                    sb.Append(info[i]);
                }

            }

            Console.WriteLine(sb.ToString());
        }

    }
}
