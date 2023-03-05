Console.WriteLine("Задача № 19. Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.!");

int GetNumber(string s)
{
    Console.Write(s);

    int result;
    while (!int.TryParse(Console.ReadLine(), out result)) ;
    return result;
}

bool CheckLenghtNumber(int n)
{
    if (n < 10000 || n > 99999)
    {
        Console.WriteLine("Число должно быть пятизначным!");
        return false;
    }
    return true;

}

string GetResult(int n)
{
    if (n % 10 == n / 10000)
    {
        if ((n / 1000) % 10 == (n / 10) % 10)
        {
            return ("Число является палиндромом");
        }
    }
    return ("Число не является палиндромом");
}

int num = GetNumber("Введите пятизначное число n: ");
bool lenghNum = CheckLenghtNumber(num);

if (lenghNum)
{
    Console.WriteLine(GetResult(num));
}
