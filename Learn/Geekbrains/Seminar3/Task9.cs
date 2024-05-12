using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Task9
    {
        static void Main9(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 , 12, 13, 14 };
            var result = nums.MyWhere(x => x % 2 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
