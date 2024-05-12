// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num%7 == 0 && num%23 == 0)
    Console.Write("Кратно");
else
    Console.Write("Не кратно");


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое  число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1*num1 == num2 || num2*num2 == num1) Console.WriteLine("Да");
else Console.WriteLine("Нет");

