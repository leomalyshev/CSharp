// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите число строк массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortDecreaseRowArray(array);
PrintArray(array);




void SortDecreaseRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        QuickSort(array, i, 0, array.GetLength(0) - 1);
    }
}

void QuickSort(int[,] array, int row, int left, int right)
{
    if (left >= right) return;

    int pivot = array[row, left];
    int i = left;
    int j = right;

    while (i <= j)
    {
        while (array[row, i] > pivot) i++;
        while (array[row, j] < pivot) j--;

        if (i <= j)
        {
            int temp = array[row, i];
            array[row,i] = array[row,j];
            array[row,j] = temp;
            i++;
            j--;
        }

        if (left < j) QuickSort(array, row, left, j);
        if (i < right) QuickSort(array, row, i, right);
    }
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

void PrintArray(int[,] matrix)
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