// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк первого массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первого массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк второго массива");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второго массива");
int j = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[n, m];
int[,] array2 = new int[n, m];

if (n != j)
{
    Console.WriteLine(@"Длина строки первого массива должна
равняться длине стобца второго массива!");
    return;
}

Console.WriteLine();
FillArray(array1);
FillArray(array2);
Print2DArray(array1);
Console.WriteLine();
Print2DArray(array2);
Console.WriteLine();
int[,] newArray = ProductMatrix(array1, array2, n, m, j);
Print2DArray(newArray);



int[,] ProductMatrix(int[,] array1, int[,] array2, int n, int m, int j)
{
    int[,] newArray = new int[n, m];
    for (int rows = 0; rows < n; rows++)
        for (int columns = 0; columns < m; columns++)
            for (int k = 0; k < j; k++)
                newArray[rows, columns] += array1[rows,k] * array2[k, columns];
    return newArray;
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
