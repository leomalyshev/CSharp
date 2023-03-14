// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int reverseNum = reverseNumber(number);
Console.WriteLine(checkPalindrome(number, reverseNum));




int reverseNumber(int number)
{
    int reverseNumber = 0;
    while (number > 0)
    {
        reverseNumber = reverseNumber * 10 + number % 10;
        number /= 10;
    }

    return reverseNumber;
}

string checkPalindrome(int number, int reverseNumber)
{
    if (number == reverseNumber)
        return "Да";
    return "Нет";
}