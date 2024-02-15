using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Task2_5
    {
        static void Main2_5(string[] args)
        {
            int[,] a = { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 }
            };

            //7,4,1
            //8,5,2
            //9,6,3
            
            
            int num1 = a.GetLength(0);
            int b = 0;

            while (b < num1)
            {
                int i = a.GetLength(0);
                while (i > 0)
                {
                    Console.Write($"{a[i-1,b]} ");
                    i--;
                }
                b++;
                Console.WriteLine("");
            }



            //while (i < num1)
            //{
            //    int j = num2 - 1;
            //    while (j >= 0)
            //    {
            //        Console.Write($"{a[j, i]} ");

            //        j--;
            //    }
            //    i++;
            //    Console.WriteLine("");
            //}
        }
    }
}

//int y = a.GetLength(0);
//int x = a.GetLength(1);

//for (int i = 0; i < y; i++)
//{
//    for (int j = x - 1; j >= 0; j--)