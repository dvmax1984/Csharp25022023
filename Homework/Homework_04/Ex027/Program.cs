Console.WriteLine("Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

int GetNumber(string s)
{
    Console.Write(s);
    int n;
    while (!int.TryParse(Console.ReadLine(), out n)) ;
    return n;
}

int GetResult(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
    return res;
}

int num = GetNumber("Введите число: ");
Console.WriteLine(GetResult(num));