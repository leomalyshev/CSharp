// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите числа через запятую");
string input = Console.ReadLine();
string[] parts = input.Split(", ");
PrintArray(parts);



void PrintArray(string[] array)
{
    int[] numbers = new int[array.Length];
    Console.Write("[");
    for (int i = 0; i < parts.Length - 1; i++)
    {
        numbers[i] = Convert.ToInt32(parts[i]);
        Console.Write($"{numbers[i]}, ");
    }
    numbers[parts.Length-1] = Convert.ToInt32(parts[parts.Length-1]);
    Console.Write($"{numbers[parts.Length-1]}]");
}
