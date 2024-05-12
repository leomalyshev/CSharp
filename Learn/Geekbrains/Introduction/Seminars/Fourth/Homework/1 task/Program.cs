// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число возводимое в степень");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pow(a,b));


int Pow(int a, int b)
{
    int pow = 1;
    for (int i = 1; i<=b; i++)
        pow =* a;
    return pow;
}