// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
double[] newMatrix = GetArithmeticMean(matrix);
PrintArray2(newMatrix);




double[] GetArithmeticMean(int[,] matrix)
{
    int lengthRow = matrix.GetLength(0);
    int lengthColumn = matrix.GetLength(1);
    double[] average = new double[lengthColumn];
    for (int column = 0; column < lengthColumn; column++)
    {
        double sum = 0;
        for (int row = 0; row < lengthRow; row++)
        {
            sum+=matrix[row, column]; 
        }
        average[column] = Math.Round(sum/lengthRow, 1);
    }
    return average;
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

void PrintArray2(double[] array)
{
    foreach (double num in array)
    {
        Console.Write(num);
        Console.Write(" ");
    }   
}
