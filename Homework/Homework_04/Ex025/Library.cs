public static class Library
{
    public static double GetNumber(string s)
    {
        Console.Write(s);
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    public static double GetResult(double a, double b)
    {
        return Math.Pow(a, b);
    }
}