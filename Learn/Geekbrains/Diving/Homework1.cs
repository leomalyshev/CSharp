namespace Diving
{
    internal class Homework1
    {
        delegate int Operation(int x, int y);
        static int Add(int x, int y) => x + y;
        static int Multiply(int x, int y) => x * y;
        static int Subtract(int x, int y) => x - y;
        static int Divide(int x, int y) => x / y;
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Аргументы не были предоставлены.");
                return;
            }

            if (!int.TryParse(args[0], out int num1) || !int.TryParse(args[2], out int num2))
            {
                Console.WriteLine("Один из аргументов не является числом.");
                return;
            }

            string sign = args[1];

            var operations = new Dictionary<string, Operation>
            {
                { "+", Add },
                { "-", Subtract },
                { "*", Multiply },
                { "/", Divide }
            };

            if (operations.TryGetValue(sign, out var operation))
            {
                if (sign == "/" && num2 == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль.");
                    return;
                }
                int value = operation(num1,num2);
                Console.WriteLine($"Результат равен: {value}");
            }
            else
            {
                Console.WriteLine("Неверный знак операции.");
            }

            
        }
        
    }
}
