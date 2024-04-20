namespace ARV
{
    internal class Program
    {
        private static bool started = true;
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        static void ThreadProc1()
        {
            while (started)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(200);
                }

                Console.WriteLine();
                // Set - установка в сигнальное состояние
                autoResetEvent.Set();
                autoResetEvent.WaitOne();
            }
        }

        static void ThreadProc2()
        {
            while (started)
            {
                // WaitOne - ждет сигнального состояния, и потом сбрасывает сигнальное состояние
                autoResetEvent.WaitOne();
                Console.WriteLine("2 seconds");
                autoResetEvent.Set();
            }
        }
        static void Main(string[] args)
        {
            new Thread(ThreadProc1).Start();
            new Thread(ThreadProc2).Start();
            Thread.Sleep(10000);
            started = false;
        }
    }
}
