// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

Console.WriteLine("Введите число");
int k = Convert.ToInt32(Console.ReadLine());
int[] array = new int[k*2-1];
Fibonacci(array, k);
PrintArray(array);




void Fibonacci(int[] array, int k)
{
    k = k-1;
    array[k+1] = 1;
    array[k-1] = 1;
    for(int i = 2; i<=array.Length/2; i++)
    {
        array[k+i] = array[k+i-1]+array[k+i-2];
        array[k-i] = array[k-i+2]-array[k-i+1];
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}