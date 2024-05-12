// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
int[] array = new int[6];
FillArray(array);
PrintArray(array);
int[] newArray = MaxMinValueAndSum(array);
PrintArray(newArray);
Console.WriteLine($"Максимальное значение равно {newArray[0]}, индекс максимального значения равен {newArray[1]}");
Console.WriteLine($"Минимальное значение равно {newArray[2]}, индекс минимального значения равен {newArray[3]}");
Console.WriteLine($"Сумма чисел массива равна {newArray[4]}");
Console.WriteLine($"Медиана равна {Median(array)}");




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

int[] MaxMinValueAndSum(int[] array)
{
    int[] newArray = new int[5];
    newArray[0] = array[0];
    newArray[2] = array[0];
    for (int i = 0; i  < array.Length; i++)
    {
        if (array[i] > newArray[0])
        {
            newArray[0] = array[i];
            newArray[1] = i;
        } 
        if (array[i] < newArray[2])
        {
            newArray[2] = array[i];
            newArray[3] = i;
        }
        newArray[4]+=array[i];
    }
    return newArray;
}

int Median(int[] array)
{
    int medium = array.Length/2 + array.Length%2;
    int sum = 0;
    if (medium%2!=0)
        sum+=array[array.Length/2] + array[array.Length/2-1];
    else
        sum+=array[medium-1];
    return sum;
}