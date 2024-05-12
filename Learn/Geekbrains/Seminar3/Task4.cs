namespace Seminar3
{
    public class Task4
    {
        static void Main4(string[] args)
        {
            List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };

            List<int> newInts = [];

            HashSet<int> hashSet = new HashSet<int>();

            foreach (var value in ints)
            {
                hashSet.Add(value);
            }

            foreach (var value in ints)
            {
                if (!newInts.Contains(value))
                {
                    newInts.Add(value);
                }
            }


            foreach (var hash in newInts)
            {
                Console.WriteLine(hash);
            }
        }
    }
}
