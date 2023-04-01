// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
FillArray(array);
Print2DArray(array);
Console.WriteLine();
int[] sumArray = SumRowArray(array);
Print1DArray(sumArray);
GetMinValue(sumArray);


void GetMinValue(int[] array)
{
    int minRowIndex = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[minRowIndex])
            minRowIndex = i;
    Console.WriteLine($"Номер строки с наименьшей суммой: {minRowIndex}");
}

int[] SumRowArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(1)];
    
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            sumArray[rows] += array[rows, columns];
        }
    }
    return sumArray;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Print1DArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}