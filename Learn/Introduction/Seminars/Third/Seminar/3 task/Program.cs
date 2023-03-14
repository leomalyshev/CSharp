// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

/* Console.WriteLine("Введите x 1 точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y 1 точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x 2 точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y 2 точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DistancePount(x1, y1, x2, y2));




double DistancePount(int x1, int y1, int x2, int y2)
{
    double result1 = (x2 - x1)*(x2 - x1);
    double result2 = (y2 - y1)*(y2 - y1);
    double result = Math.Sqrt(result1 + result2);
    return result;
} */

//√((x2 - x1)² + (y2 - y1)²)

/*  Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    Console.Write($"{i * i} ");
}