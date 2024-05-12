// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());


void CheckCoord(int x, int y)
{
    if (x>0 && y>0)
        Console.WriteLine("quarter №1");
    else if (x<0 && y>0)
        Console.WriteLine("quarter №2");
    else if (x<0 && y<0)
        Console.WriteLine("quarter №3");
    else if (x>0 && y<0)
        Console.WriteLine("quarter №4");
    else
        Console.WriteLine("The point is located on the coordinate axis");
}

// CheckCoord(x,y);

int CheckCoord2(int x, int y)
{
    int res = 0;
    if (x>0 && y>0)
        res=1;
    else if (x<0 && y>0)
        res=2;
    else if (x<0 && y<0)
        res=3;
    else if (x>0 && y<0)
        res=4;
    return res;
}

Console.WriteLine($"Это четверть {CheckCoord2(x,y)}");
