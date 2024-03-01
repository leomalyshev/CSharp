using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    public class Task5
    {
        static void Main6(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };

            Dictionary<int, int> upDictionary = new Dictionary<int, int>();

            foreach (var i in ints)
            {
                if (upDictionary.ContainsKey(i)) upDictionary[i]++;
                else
                {
                    upDictionary[i] = 1;
                }
            }

            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();


            foreach (var upDict in upDictionary)
            {
                priorityQueue.Enqueue(upDict.Key,upDict.Value);
            }


            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}
