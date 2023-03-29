// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. 

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
CheckTriangle(a, b, c);




void CheckTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
        Console.WriteLine("Треугольник может существовать");
    else
        Console.WriteLine("Треугольник не может существовать");
}
