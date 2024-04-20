using System.Threading;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            Thread thread1 = new Thread(() => foo.First(() => Console.WriteLine("First")));
            Thread thread2 = new Thread(() => foo.Second(() => Console.WriteLine("Second")));
            Thread thread3 = new Thread(() => foo.Third(() => Console.WriteLine("Third")));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }

    public class Foo
    {
        AutoResetEvent waitHandler1 = new AutoResetEvent(false);
        AutoResetEvent waitHandler2 = new AutoResetEvent(false);

        public Foo()
        {
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            waitHandler1.Set();
        }

        public void Second(Action printSecond)
        {
            waitHandler1.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            waitHandler2.Set();
        }

        public void Third(Action printThird)
        {
            waitHandler2.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}