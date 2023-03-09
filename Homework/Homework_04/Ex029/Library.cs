public static class Library
{
    // Задаем длинну массива
    public static int GetNumber(string s)
    {
        Console.Write(s);

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    // Заполняем массив произвольно
    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 99);
        }
    }
    public static string GetResult(int[] array)
    {
        string res = string.Empty;
        string sep = "], ";

        for (int j = 0; j < array.Length; j++)
        {
            if (j == array.Length)
            {
                sep = "]";
            }

            res = res + "[" +  array[j] + sep;
        }
        return res;
    }

}