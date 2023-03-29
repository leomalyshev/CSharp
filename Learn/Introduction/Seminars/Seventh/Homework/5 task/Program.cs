Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
bool check = CheckParity(rows, cols);
int[,] array;
if (check)
{
    array = new int[rows,cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    int[] oneDArray = ShuffleOneDArray(array, rows, cols);
    int[,] shuffleArray = ShuffleArray(array, rows, cols, oneDArray);
    PrintArray(shuffleArray);
} 
    

int[,] ShuffleArray(int[,] array, int m, int n, int[] oneDArray)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = oneDArray[i * n + j];
    return array;
}

int[] ShuffleOneDArray(int[,] array, int m, int n)
{
    int[] oneDArray = new int[m * n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            oneDArray[i * n + j] = array[i, j];
    
    int mid = oneDArray.Length/2;
    for (int i = 0; i < mid; i++)
    {
        int temp = oneDArray[i];
        oneDArray[i] = oneDArray[mid+i];
        oneDArray[mid+i] = temp;
    }
    
    return oneDArray;
}

bool CheckParity(int rows, int cols)
{
    bool check = true;
    if (rows*cols%2!=0)
    {
        Console.WriteLine("Количество элементов массива должно быть четным");
        check = false;
    }
    return check;
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
