public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    public static int A(int n, int m)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return A(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return A(m - 1, A(m, n - 1));
        }
    }
}