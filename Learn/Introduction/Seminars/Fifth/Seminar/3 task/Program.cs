// Задача 35: Задайте одномерный массив из 12  случайных чисел диапазоном от -100 до 100. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5 элементов
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine(Count(array));




void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i  < array.Length; i++)
        if (array[i] > 9 && array[i] < 100)
            count++;
    return count;
}