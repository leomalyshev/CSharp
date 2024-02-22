// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
PrintNumber1(5,10);

void PrintNumber(int n, int current = 1)
{
    if (current > n) return;

    Console.Write(current + " ");
    PrintNumber(n, current + 1);
}

// PrintNumber(5);

void PrintNumber1(int n, int m)
{
    if (n > m) return;

    Console.Write(n + " ");
    PrintNumber1(n+1, m);
}


