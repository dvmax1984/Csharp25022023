public static class Library
{
    public static int GetNumber(string s, int[] arr, int n, int count)
    {
        Console.Write(s);

        if (n == arr.Length) return count+100;

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        arr[n] = result;
        if (result > 0) {count += 1;}
        n += 1;
        count += GetNumber($"Шаг {n} из {arr.Length} - {arr[n - 1]} - count {count} ", arr, n, count);
        return count+1000;
    }
}