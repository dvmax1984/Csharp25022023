public static class Method
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    public static int GetSumNatural(int m, int n)
    {
        int sum = 0;

        for (int i = m, j = 0; i <= n; i++, j++)    // добавил переменную j и её инкремент для перечисления эл. массива
        {
            sum += i;
        }

        return sum;
    }

    public static int GetSumNaturalRec(int n, int m)
    {
        if (n - 1 == m) return 0;      //n-1 это по сути отнимаем один шаг от того что ранее прибавили в функции
        else
        {
            //Console.WriteLine($"n = {n}");
            return n + GetSumNaturalRec(n + 1, m);
        }

        // в функции n+1 Это аргумент и счетчик переход на следующиее число n=5  5 + f(5+1, 7) = вернет 6
    }
}