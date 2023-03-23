public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    public static bool CheckLenghtNumber(int n)
    {
        if (n < 10000 || n > 99999)
        {
            Console.WriteLine("Число должно быть пятизначным!");
            return false;
        }
        return true;

    }

    public static string GetResult(int n)
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
}