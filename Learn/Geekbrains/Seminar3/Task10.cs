using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Task10
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.GotResult += Calculator_GotResult;

            //Console.WriteLine("Введите число");
            //int.TryParse(Console.ReadLine(), out int firstValue);

            bool isCancel = false;

            while (!isCancel)
            {
                Console.WriteLine("Введите операнд");
                var operand = Console.ReadLine();
                Console.WriteLine("Введите число");
                int.TryParse(Console.ReadLine(), out int secondValue);

                switch (operand)
                {
                    case "+":
                        calc.Add(secondValue);
                        break;
                    case "-":
                        calc.Subtract(secondValue);
                        break;
                    case "/":
                        calc.Divide(secondValue);
                        break;
                    case "*":
                        calc.Multiply(secondValue);
                        break;
                    case " ":
                        isCancel = true;
                        break;
                    default:
                        Console.WriteLine("Введен некорректный операнд или число");
                        break;
                }
            }
        }

        private static void Calculator_GotResult(object? sender, OperandChangedEventArgs e)
        {
            Console.WriteLine(e.Operand);
        }
    }
}