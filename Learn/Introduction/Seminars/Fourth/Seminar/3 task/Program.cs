// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.WriteLine("Введите натуральное число");
// int a = Convert.ToInt32(Console.ReadLine());
// Sum(a);




// void Sum(int a)
// {
//     int sum = 1;
//     for (int i = 1; i <= a; i++)
//         sum*=i;
//     Console.WriteLine($"Факториал числа {a} равен {sum}");
// }

// Сделать функцию булевого типа которая определяет больше ли единиц чем нулей


Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(n);
PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine(GetValueBoolean(array));




bool GetValueBoolean(int[] array)
{
    int counter1 = 0;
    int counter2 = 0;
    foreach (int a in array)
        {
            if (a == 0)
                counter1++;
            else
                counter2++;
        }
    if (counter1 < counter2)
        return true;
    return false;
}

void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write(num);
        Console.Write(" ");
    }
        
}

int[] FillArray(int num)
{
    int[] array = new int[n];
    int i = 0;
    while (i < array.Length)
    {
        int random = new Random().Next(0,2);
        array[i] = random;
        i++;
    }
    return array;
