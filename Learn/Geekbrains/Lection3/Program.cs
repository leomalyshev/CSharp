namespace Lection3
{
    internal class Program
    {
        //static object lockObj = new object();
        //static void Print()
        //{
        //    lock (lockObj)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"{Thread.CurrentThread.GetHashCode()}:{i}");
        //        }
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    List<Task> tasks = new List<Task>();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        tasks.Add(Task.Run(Print));
        //    }

        //    Task.WaitAll(tasks.ToArray());
        //}

        //static int GetValue1()
        //{
        //    Thread.Sleep(1000);
        //    return 1;
        //}

        //static int GetValue2()
        //{
        //    Thread.Sleep(2000);
        //    return 2;
        //}

        //static void Main(string[] args)
        //{
        //    Task<int> v1 = Task.Run(GetValue1);
        //    Task<int> v2 = Task.Run(GetValue2);

        //    v1.Wait();
        //    v2.Wait();

        //    Console.WriteLine(v1.Result + v2.Result);
        //}

        //static private CancellationTokenSource cts = new CancellationTokenSource();
        //static private CancellationToken ct = cts.Token;

        //static void WriteParallel()
        //{
        //    int c = 1;
        //    while (!ct.IsCancellationRequested)
        //    {
        //        Console.WriteLine("Privet!" + c++);
        //        Thread.Sleep(200);
        //    }

        //    ct.ThrowIfCancellationRequested();
        //}

        //static void Main(string[] args)
        //{
        //    //Action action = WriteParallel;

        //    //Task t = new Task(action);
        //    //t.Start();
        //    //t.Wait();
        //    Task t = new Task(WriteParallel, ct);

        //    t.Start();

        //    Thread.Sleep(1000);

        //    cts.Cancel();

        //    try
        //    {
        //        t.Wait();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException);
        //    }
        //}

        //static void WriteParallel(object s)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(s);
        //        Thread.Sleep(100);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Task t1 = new Task(WriteParallel, "Flip");
        //    Task t2 = new Task(WriteParallel, "Flop");

        //    t1.Start();
        //    t2.Start();

        //    Thread.Sleep(1000);
        //    t1.Wait();
        //    t2.Wait();
        //}

        //static Task WriteParallel()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(i);
        //        Thread.Sleep(100);
        //    }

        //    return Task.CompletedTask;
        //}

        //static void Main(string[] args)
        //{
        //    Task t1 = WriteParallel();
        //    t1.Wait();
        //}

        static void WriteParallel()
        {
            Thread.Sleep(100);
            Console.WriteLine("Исключение идем следом!");

            throw new Exception("Просто исключение");
        }

        static void Main(string[] args)
        {
            //var t = new Thread(WriteParallel);
            //t.IsBackground = false;
            //t.Start();

            //Console.WriteLine("Заверашаем работу");

            new Task(WriteParallel).Start();

            Thread.Sleep(200);
            Console.WriteLine("Заверашаем работу");

            //var t1 = new Task(Do1);
            //var t2 = t1.ContinueWith((x) => Do2());
            //t1.Start();

        }
    }
}