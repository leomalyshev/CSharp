using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving
{
    internal class Homework2
    {
        static void Main(string[] args)
        {
            int[][] df;

            int[,] a = { 
                { 7, 3, 2 }, 
                { 4, 9, 6 }, 
                { 1, 8, 5 }
            };


            int pastMin = int.MinValue;

            for (int x = 0; x < a.GetLength(0); x++)
            {
                for (int y = 0; y < a.GetLength(1); y++)
                {
                    int min = a[x, y];
                    
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            if (a[i, j] < min && a[i, j] > pastMin)
                            {
                                (a[i, j], a[x, y]) = (a[x, y], a[i, j]);

                                min = a[x, y];
                                
                            }
                        }
                    }
                    pastMin = min;

                    Console.Write(min + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
