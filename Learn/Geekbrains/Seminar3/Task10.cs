using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Seminar3
{
    internal class Task10
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.GotResult += Calculator_GotResult;
            bool isCancel = false;

            CalculatorActionLog calculatorActionLog = new CalculatorActionLog();

            try
            {
                while (!isCancel)
                {
                    Console.WriteLine("Введите операнд");
                    var operand = Console.ReadLine();
                    Console.WriteLine("Введите число");
                    double.TryParse(Console.ReadLine(), out double secondValue);

                    calculatorActionLog.AddLog(secondValue, operand);

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
            catch (CalculatorDivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + calculatorActionLog.GetLog());
            }
            catch (CalculateOperationCauseOverflowException ex)
            {
                Console.WriteLine(ex.Message + calculatorActionLog.GetLog());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + calculatorActionLog.GetLog());
            }
        }

        private static void Calculator_GotResult(object? sender, OperandChangedEventArgs e)
        {
            Console.WriteLine(e.Operand);
        }
    }
}