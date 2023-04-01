// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[,] matrix2 = TransponseArray(matrix, n, m);
PrintArray(matrix2);




int[,] TransponseArray(int[,] matrix, int n, int m)
{
    int[,] matrix2 = new int[n, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[i,j] = matrix[j,i];
        }
    }
    return matrix2;
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