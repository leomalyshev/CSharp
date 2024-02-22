int x = Convert.ToInt32(Console.ReadLine());
int result = (int)Math.Floor(Math.Log(x, 10) + 1);

if (result<3) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(x%10);
