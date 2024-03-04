using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Task8
    {
        static void Main8(string[] args)
        {
            int[] arr = { 1, 2, 3, 44, 5, 6, 7, 8, 9, 10, 11 };

            int target = 6;

            var s = new HashSet<int>();

            int[] arr2 = { 12, 3, 4, 1, 6, 9 }; // 1, 3, 4, 6, 9, 12
            int sum = 24;




            foreach (var i in arr)
            {
                var x = target - i; // 5 = 6 - 1
                if (arr.Contains(x))
                {
                    foreach (var j in arr)
                    {
                        var y = x - j; // 3 = 5 - 2
                        if (arr.Contains(y) && target == y + i + j)
                        {
                            Console.WriteLine($"{y} + {i} + {j} = {target}");
                            return;
                        }

                    }
                }
                
            }
        }
    }
}
