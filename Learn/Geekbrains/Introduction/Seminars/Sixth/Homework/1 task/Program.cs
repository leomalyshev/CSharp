// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 5
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество цифр");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberMoreZero(m));


int NumberMoreZero(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите любое число");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0) count++;
    }
    return count;
}
