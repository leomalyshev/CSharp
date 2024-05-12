int[] array = new int[12];
FillArray(array);
PrintArray(array);
Sum(array);
int[] res = Sum2(array);
Console.WriteLine($"Сумма2 положительных элементов равна {res[0]}");
Console.WriteLine($"Сумма2 орицательных элементов равна {res[1]}");


void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(-9,10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void Sum(int[] array)
{
    int sump = 0;
    int sumn = 0;
    foreach (int item in array)
        if (item > 0)
            sump+=item;
        else
            sumn+=item;
    Console.WriteLine($"Сумма положительных элементов равна {sump}");
    Console.WriteLine($"Сумма положительных элементов равна {sumn}");
}

int[] Sum2(int[] array)
{
    int sump = 0;
    int sumn = 0;
    foreach (int item in array)
        if (item > 0)
            sump+=item;
        else
            sumn+=item;
    int[] results = {sump, sumn};
    return results;
}