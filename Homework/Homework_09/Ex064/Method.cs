public static class Method
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
  
    public static void GetResult(int n)
    {
        if (n > 1) Console.Write($"{n}, "); 

        if (n == 1) Console.Write($"{n} \n");
        
        if (n > 1) GetResult(n - 1);
    }
}