public static class Library3
{
    public static void PrintEnd(int[]array1, int[]array2)
    {
        for (var i = 0; i < array2.Length; i++)
        {
            Console.WriteLine($"{array1[i]} встречается {array2[i]} раз");
        }
    }
}