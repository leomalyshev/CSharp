using System.ComponentModel;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bits bits2 = new Bits(100);
            Bits bits = new Bits(200);

            //bits2[0] = false;
            //bits[2] = false;
            //Console.WriteLine(bits2.Value);
            long num = (long)bits;
            Console.WriteLine(num.GetType().ToString());

            var num2 = 123;
            Bits bits3 = num2;

        }
    }
}
