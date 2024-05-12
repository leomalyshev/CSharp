using Microsoft.VisualBasic.CompilerServices;

namespace TLock
{
    internal class Program
    {
        static object lockObj = new object();

        static void ThreadProc()
        {
            lock (lockObj)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}:{i}");
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var t = new Thread(ThreadProc);
                t.Name = "Thread " + i;
                t.Start();
            }
        }
    }
}