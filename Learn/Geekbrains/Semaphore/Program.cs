namespace Semaphore
{
    internal class Program
    {
        static System.Threading.Semaphore semaphore = new(2, 2);

        static void ThreadProc(int x)
        {
            try
            {
                semaphore.WaitOne();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(x);
                    Thread.Sleep(200);
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = i;
                new Thread(() => {ThreadProc(x);}).Start();
            }
        }
    }
}
