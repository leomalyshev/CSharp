// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число для суммирования");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(a));


int Sum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a%10;
        a = a/10;
    }
    return sum;
}

