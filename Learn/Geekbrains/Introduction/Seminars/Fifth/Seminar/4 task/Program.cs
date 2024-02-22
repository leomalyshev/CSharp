// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] array = new int[5];
FillArray(array);
PrintArray(array);
int[] newArray = Multiplication(array);
PrintArray(newArray);




void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int[] Multiplication(int[] array)
{
    double size = Math.Ceiling(array.Length/2.0);
    //int size = array.Length/2 + array.Length%2;
    int[] arr = new int[(int)size];

    for (int i = 0; i  < array.Length/2; i++)
    {
        arr[i] = array[i] * array[array.Length-1-i]; 
    }
    if (array.Length%2!=0)
        arr[(int)size-1] = array[(int)size-1];
    return arr;
}