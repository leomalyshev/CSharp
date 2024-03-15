namespace Seminar_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework.SearchFile(args[0], args[1], args[2]);

            foreach (var line in Homework.list)
            {
                Console.WriteLine(line);
            }
        }
    }
}
