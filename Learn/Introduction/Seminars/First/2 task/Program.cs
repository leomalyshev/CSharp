int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int[] number = {a, b, c};

int i = 0;

while (i < number.Length-1)
{
    if (number[i] > number[i+1])
    {
        number[i+1] = number[i];
        number[i] = number[i+1];
        i++;
    }
    else
    {
        i++;
    }
}

Console.WriteLine(number[number.Length-1]);