// Задача 26: Напишите программу, которая принимает на вход целое или вещественное число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89,126 -> 5

Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
int count = 0;
int number2 = (int)Transformation(num);
Counter(number2);




double Transformation(double number)
{
    while (number%1 > 0.0001)
    {
        number *= 10;
    }

    return number;
}

void Counter(int a)
{
    while (a > 0)
        {
            a /= 10; 
            count++;
        }
        Console.WriteLine($"Количество цифр в числе = {count}");
}