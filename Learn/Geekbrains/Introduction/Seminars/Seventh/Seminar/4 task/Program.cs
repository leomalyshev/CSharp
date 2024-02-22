// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали  и отдельно сумму элементов обратной диагонали.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// Сумма элементов обратной диагонали: 8+9+7 = 24
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,cols];
FillArray(array);
PrintArray(array);
Console.WriteLine(SumDiagonals1(array));
Console.WriteLine(SumDiagonals2(array));




int SumDiagonals1(int[,] array)
{
    int sum = 0;
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            if (i==j)
                sum+=array[i,j];
    return sum;   
}

int SumDiagonals2(int[,] array)
{
    int sum = 0;
    for (int i=0; i<array.GetLength(0); i+=1)
        for (int j=0; j<array.GetLength(1); j+=1)
            if (array.GetLength(0)-1-i==j)
                sum+=array[i,j];
    return sum;   
}

void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,11);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
    }        
}

