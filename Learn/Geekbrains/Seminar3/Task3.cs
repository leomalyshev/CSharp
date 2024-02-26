using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Есть лабиринт описанный в виде двумерного массива где 1 это стены, 0 - проход, 2 - искомая цель.
   Пример лабиринта:
   1 1 1 1 1 1 1
   1 0 0 0 0 0 1
   1 0 1 1 1 0 1
   0 0 0 0 1 0 2
   1 1 0 0 1 1 1
   1 1 1 1 1 1 1
   1 1 1 1 1 1 1
   Напишите алгоритм определяющий наличие выхода из лабиринта и выводящий на экран  координаты точки выхода если таковые имеются.
   
   Пример описания лабиринта.
   int[,] labirynth1 = new int[,]
           {
               {1, 1, 1, 1, 1, 1, 1 },
               {1, 0, 0, 0, 0, 0, 1 },
               {1, 0, 1, 1, 1, 0, 1 },
               {0, 0, 0, 0, 1, 0, 2 },
               {1, 1, 0, 0, 1, 1, 1 },
               {1, 1, 1, 1, 1, 1, 1 },
               {1, 1, 1, 1, 1, 1, 1 }
           };
   Пример заголовка функции которая должна определить наличие выхода из лабиринта:
   static bool HasExix(int startI, int startJ, int[,] l)
   startI,startJ  это точка начала пути-откуда мы начинаем проходить лабиринт. 
   l - массив описывающий лабиринт.
 */

namespace Seminar3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            int[,] labirynth = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 2 },
                {1, 1, 0, 0, 2, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 }
            };

            int exitCount = HasExit(1, 1, labirynth);

            if ( exitCount > 0)
                Console.WriteLine($"Количество выходов равно {exitCount}");
            else
            {
                Console.WriteLine("Выхода нет");
            }

        }

        static int HasExit(int startI, int startJ, int[,] labirinth)
        {
            int count = 0;

            Queue<(int, int)> coord = [];

            if (labirinth[startI, startJ] != 1)
                coord.Enqueue((startI, startJ));

            while (coord.Count > 0)
            {
                (int i, int j) = coord.Dequeue();
                if (labirinth[i, j] == 2)
                    count++;

                labirinth[i, j] = 1;

                if (i - 1 >= 0 && labirinth[i - 1, j] != 1)
                    coord.Enqueue((i - 1, j));
                if (i + 1 < labirinth.GetLength(0) && labirinth[i + 1, j] != 1)
                    coord.Enqueue((i + 1, j));
                if (j - 1 >= 0 && labirinth[i, j - 1] != 1)
                    coord.Enqueue((i, j - 1));
                if (j + 1 < labirinth.GetLength(1) && labirinth[i, j + 1] != 1)
                    coord.Enqueue((i, j + 1));

            }

            return count;
        }
    }
}


