int x = Convert.ToInt32(Console.ReadLine());
int result = (int)Math.Floor(Math.Log(x, 10) + 1);

if (result>1)
{
    int digit = x/(int)Math.Pow(10, result-2);
    Console.Write(digit%10);
}
else Console.WriteLine("Sorry, dude");
