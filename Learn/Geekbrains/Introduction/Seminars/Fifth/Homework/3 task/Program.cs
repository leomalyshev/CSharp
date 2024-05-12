// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Разница между max и min равна {DifferensMaxMin(array)}");




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

int DifferensMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach (int item in array)
    {
        if (item > max) max = item;
        if (item < min) min = item;
    }
    return max - min;
}

