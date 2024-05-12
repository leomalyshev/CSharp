namespace Seminar_2
{
    internal class Program
    {
        private static int[] _arr1 = [1, 2, 3, 5, 8];
        private static int[] _arr2 = [4, 6, 9, 10, 12];

        static void Main(string[] args)
        {

            //Thread thread1 = new Thread(GetSum1);
            //Thread thread2 = new Thread(GetSum2);
            //thread1.Start();
            //thread2.Start();
            //thread1.Join();
            //thread2.Join();
            //Console.WriteLine($"{_sum1} + {_sum2} = {_sum1 + _sum2}");

            int res1 = 0;
            int res2 = 0;
            Thread newThread1 = new Thread(() => { res1 = GetSum3(_arr1); });
            Thread newThread2 = new Thread(() => { res2 = GetSum3(_arr2); });
            newThread1.Start();
            newThread2.Start();
            newThread1.Join();
            newThread2.Join();
            Console.WriteLine($"{res1} + {res2} = {res1 + res2}");
        }

        public static int GetSum3(int[] arr)
        {
            return arr.Sum();
        }

        public static void GetSum1()
        {
            _sum1 = _arr1.Sum();
        }

        public static void GetSum2()
        {
            _sum2 = _arr2.Sum();
        }
    }
}