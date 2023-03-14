public static class Library
{
    public static int GetNumber(string s, int[] arr, int n)
    {
        Console.Write(s);

        if (n == arr.Length) return 0;

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        arr[n] = result;
        n += 1;
        GetNumber($"Шаг {n} из {arr.Length} - {arr[n - 1]} ", arr, n);
        return 0;
    }
}