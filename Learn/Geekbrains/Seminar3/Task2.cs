using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Task2
    {
        static void Main2(string[] args)
        {
            CustomEnumerale customEnumerale = new CustomEnumerale();

            foreach (var cs in customEnumerale)
            {
                Console.WriteLine(cs);
            }

        }

    }
}
