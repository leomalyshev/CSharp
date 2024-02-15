using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Task2_3
    {
        static void Main2_3(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[rnd.Next(1, 10)];
            int[] b = new int[rnd.Next(1, 10)];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 100);
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(1, 100);
            }

            Console.WriteLine(string.Join(",", Sorted(a,b)));

        }

        private static int[] Sorted(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length + array2.Length];
            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                newArray[i] = array1[i];
                j++;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                newArray[j] = array2[i];
                
            }

            Array.Sort(newArray);

            return newArray;
        }
    }
}
