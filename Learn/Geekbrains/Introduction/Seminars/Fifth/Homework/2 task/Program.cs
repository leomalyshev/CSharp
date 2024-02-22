// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов равна {SumUnevenNumbers(array)}");




void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(0,100);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int SumUnevenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2!=0)
            sum+=array[i];
    return sum;
}