Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Искомая сумма равна {Sum(num)}");
Console.WriteLine($"Искомая сумма равна {Sum1(5)}");




int Sum(int num)
{
    int sum = 0;
    while(true)
    {
        if (num==0) break;
        sum+=num;
        num--;
    }
    return sum;
}

int Sum1(int num)
{
    if (num==0) return 0;
    return num + Sum1(num-1);
}

// Sum1(5)
// 5 + (4 + (3 + 2 + (1 + 0)))