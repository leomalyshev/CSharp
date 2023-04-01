// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2    
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9  2  3
// 4  2  4
// 2  6  7

// массив становится на размер меньше
// перебрать весь массив
// берем первое попавшееся маленькое число
// сверху и снизу от числа убрать числа
// делаем новый массив меньшего размера m-1, n-1
// заполнить с пропуском определенной строки и столбца
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
int minRow = 0, minCol = 0;
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int min = FindMinElementInArray(matrix);


bool[,] matrix2 = new bool[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j != minCol && i != minRow)
            matrix2[i,j] = true;
        else
            matrix2[i,j] = false;
    }
} 

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix2[i,j] != false)
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
        Console.WriteLine();
    }

int FindMinElementInArray(int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < min)
            {
                min = matrix[i,j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return min;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
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
