public static class Library
{
    public static double GetNumber(string s)
    {
        Console.Write(s);
        //return Convert.ToInt32(Console.ReadLine());        
        
        double result;
        while(!double.TryParse(Console.ReadLine(), out result));
        return result;    
}
    public static double GetResult(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        // Расчетная формула
        // L = SQR ((x2 - x1)^2 + (y2 + y1)^2 - (z2 + z1)^2)

        double x = Math.Pow(x2 - x1, 2);
        double y = Math.Pow(y2 - y1, 2);
        double z = Math.Pow(z2 - z1, 2);

        double l = Math.Sqrt(x + y + z);

        return Math.Round(l, 2);
    }
}