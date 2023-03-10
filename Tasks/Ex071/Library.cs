public static class Library
{
    public static ulong GetNumber(string s)
    {
        Console.Write(s);
        ulong result;
        while (!ulong.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    // Описание
    // https://xn--h1ajim.xn--p1ai/index.php/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
    public static ulong A(ulong n, ulong m)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            //Console.Write(n);
            return A(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return A(m - 1, A(m, n - 1));
        }
        else 
            return n + 1;
    }
}