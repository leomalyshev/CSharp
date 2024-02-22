// 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10 
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ToBinary(num));



string ToBinary(int num)
{
    string binary = String.Empty;
    while (num>0)
    {
        binary = num%2 + binary;
        num = num/2;
    }
    return binary;
}
