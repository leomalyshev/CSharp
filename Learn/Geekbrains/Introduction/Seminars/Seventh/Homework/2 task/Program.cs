// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Напрмер, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число для поиска");
int findNumber = Convert.ToInt32(Console.ReadLine());
int n = new Random().Next(1, 10);
int m = new Random().Next(1, 10);
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
FindNumberArray(matrix, findNumber);




void FindNumberArray(int[,] matrix, int findNumber)
{
    bool check = false;
    int tempI = 0;
    int tempJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]==findNumber)
            {
                check = true;
                tempI = i;
                tempJ = j; 
            }     
        }
    }
    if (check == false)
        Console.WriteLine($"{findNumber} - такого числа в массиве нет");
    else
        Console.WriteLine($"Позиция числа - [{tempI},{tempJ}]");
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