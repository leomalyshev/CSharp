// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] array = IntersectLine(2, 5, 2, 9);
PrintArray(array);


void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

double[] IntersectLine(int b1, int k1, int b2, int k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    double[] array = {x, y};
    return array;
}
