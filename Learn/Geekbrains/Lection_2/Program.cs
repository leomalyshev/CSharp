namespace Lection_2
{
    internal class Program
    {

        static void ThreadProc(object? stateInfo)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is " + i + " " + stateInfo);
                Thread.Sleep(100);
            }

        }
        static void Main(string[] args)
        {
            /*
            var t = new Thread(
                () =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(100);
                    }
                });

            t.IsBackground = true;

            t.Start();

            Thread.Sleep(500);
            */
            /*
            var t1 = new Thread(ThreadProc);
            var t2 = new Thread(ThreadProc);

            t1.Name = "t1";
            t2.Name = "t2";
            t1.Start();
            t2.Start();

            Thread.Sleep(3000);
            isActive = false;
            */

            Console.WriteLine("count = " + ThreadPool.ThreadCount);
            ThreadPool.QueueUserWorkItem(ThreadProc, "t1");
            ThreadPool.QueueUserWorkItem(ThreadProc, "t2");
            ThreadPool.QueueUserWorkItem(ThreadProc, "t3");

            Console.WriteLine("pending count = " + ThreadPool.PendingWorkItemCount);

            Thread.Sleep(2000);

            Console.WriteLine("count = " + ThreadPool.ThreadCount);
        }
    }
}
