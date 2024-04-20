namespace Network
{
    internal class Program
    {

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine($"Main start: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            var task = await Method1();
            var result2 = await Method2();
            Console.WriteLine("Method2 завершил свою работу");
            await Task.Delay(5000);
            //var result = task.Result;
            Console.WriteLine($"Main end: {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task<int> Method1()
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(1000);
                count++;
                Console.WriteLine(count);
                Console.WriteLine($"Method1 thread: {Thread.CurrentThread.ManagedThreadId}");
            }

            //throw new Exception();
            return count;
        }

        static async Task<int> Method2()
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(1000);
                count++;
                Console.WriteLine(count);
                Console.WriteLine($"Method2 thread: {Thread.CurrentThread.ManagedThreadId}");
            }

            return count;
        }
    }
}
