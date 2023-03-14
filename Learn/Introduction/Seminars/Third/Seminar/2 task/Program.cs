// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

try
{
    Console.WriteLine("Введите номер четверти");
    int num = Convert.ToInt32(Console.ReadLine());
    CheckQuat(num);
    Console.WriteLine(CheckQuat2(num));

}
catch
{
    Console.WriteLine("Нужно было ввести целое число");
}


void CheckQuat(int num)
{
    if (num == 1)
        Console.WriteLine("Координаты X>0 и Y>0");
    else if (num == 2)
        Console.WriteLine("Координаты X<0 и Y>0");
    else if (num == 3)
        Console.WriteLine("Координаты X<0 и Y<0");
    else if (num == 4)
        Console.WriteLine("Координаты X>0 и Y<0");
    else
        Console.WriteLine("Введено некорректное значение");
}

string CheckQuat2(int num)
{
    string res = "Введено некорректное значение";
    if (num == 1)
        res = "Координаты X>0 и Y>0";
    else if (num == 2)
        res = "Координаты X<0 и Y>0";
    else if (num == 3)
        res = "Координаты X<0 и Y<0";
    else if (num == 4)
        res = "Координаты X>0 и Y<0";
    return res;
}