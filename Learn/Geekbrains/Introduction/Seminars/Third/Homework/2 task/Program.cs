// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите x 1 точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y 1 точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z 1 точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z 2 точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y 2 точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x 2 точки");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DistancePount(x1, x2, y1, y2, z1, z2));




double DistancePount(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double x = (x2 - x1)*(x2 - x1);
    double y = (y2 - y1)*(y2 - y1);
    double z = (z2 - z1)*(z2 - z1);
    double result = Math.Sqrt(x + y + z);
    return result;
}

