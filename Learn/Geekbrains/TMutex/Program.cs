﻿namespace TMutex
{
    internal class Program
    {
        static Mutex mtx = new Mutex();

        static void ThreadProc()
        {
            try
            {
                mtx.WaitOne();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}:{i}");
                }
            }
            finally
            {
                mtx.ReleaseMutex();
            }
        }

        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                var t = new Thread(ThreadProc);
                t.Name = "Thread " + i;
                t.Start();
            }
            */

            using (var mtx = new Mutex(true, "Global\\MyMytex"))
            {
                mtx.WaitOne();

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"{i}");
                    Thread.Sleep(100);
                }

                mtx.ReleaseMutex();
                mtx.ReleaseMutex();
            }
        }
    }
}
