int num = new Random().Next(10, 100);
Console.WriteLine($"Было сгенерировано число {num}");
int x1 = num/10;
int x2 = num%10;
if(x1>x2)
    Console.WriteLine($"Наибольшее цифра этого числа это {x1}");
else if (x1<x2)
    Console.WriteLine($"Наибольшее цифра этого числа это {x2}");
else
    Console.WriteLine($"Обе цифры этого числа равны");

//вывести все числа от 1 до 10 в строку
for (int i=1; i<=10; i++)
    Console.WriteLine($"{i} ");



