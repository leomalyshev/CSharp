int x = Convert.ToInt32(Console.ReadLine());
int result = (int)Math.Floor(Math.Log(x, 10) + 1);
int index = 3;
if (result > 1)
{

    int digit = x / (int)Math.Pow(10, result - 1);
    Console.Write(digit % 10);
    do
    {
        int digit2 = x / (int)Math.Pow(10, result - index);
        Console.Write(digit2 % 10);
        index++;
    }
    while (index <= result);

}

else Console.WriteLine("Sorry, dude");
