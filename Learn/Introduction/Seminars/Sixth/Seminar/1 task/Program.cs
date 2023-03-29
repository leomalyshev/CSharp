void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(0,10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0; i  < array.Length/2; i++)
        (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);
        // int temp = array[i];
        // array[i] = array[array.Length - 1 - i];
        // array[array.Length - 1 - i] = temp;
}

Console.WriteLine($"Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
ReverseArray(array);
PrintArray(array);