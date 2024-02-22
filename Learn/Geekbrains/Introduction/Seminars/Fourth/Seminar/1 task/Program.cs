Console.WriteLine("Введите натуральное число");
int A = Convert.ToInt32(Console.ReadLine());
Sum(A);
Console.WriteLine($"Сумма по 2 функции всех чисел от 1 до {A} равна {Sum2(A)}");




void Sum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
        sum+=i;
    Console.WriteLine($"Сумма всех чисел от 1 до {A} равна {sum}");
}

int Sum2(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
        sum+=i;
    return sum;
}