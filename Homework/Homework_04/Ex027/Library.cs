public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        int n;
        while (!int.TryParse(Console.ReadLine(), out n)) ;
        return n;
    }

    public static int GetResult(int n)
    {
        int res = 0;
        while (n > 0)
        {
            res = res + n % 10;
            n = n / 10;
        }
        return res;
    }
}