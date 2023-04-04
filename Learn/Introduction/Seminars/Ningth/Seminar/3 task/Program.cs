// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(n));

int Sum(int num)
{
    if (num==0) return 0;
    return num%10 + Sum(num/10);
}

Console.WriteLine(Degree(3, 5));

int Degree(int n, int m)
{
    if (m==1) return n;
    return Degree(n, m-1) * n;
}
