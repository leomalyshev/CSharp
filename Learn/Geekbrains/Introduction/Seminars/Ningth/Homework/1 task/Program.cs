// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(num));

string PrintNumber(int num)
{
    if (num == 1) return string.Empty;
    return num + " " + PrintNumber(num-1);
}
