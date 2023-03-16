public static class Library
{
    public static int GetNumber(string s, int[] arr, int n)
    {
        Console.Write(s);

        int result;
        //while (!int.TryParse(Console.ReadLine(), out result));
        //arr[n] = result;
        //n += 1;

        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out result) && (result >= -99 && result <= 99))
                break;
            else
            {
                Console.WriteLine("Вввели не двух значное число");
                Console.Write("Повтори ввод двух значного числа: ");
            }
        }

        arr[n] = result;
        n += 1;

        if (n == arr.Length)
        {
            Console.WriteLine();
            return 0;
        }

        //GetNumber($"Шаг {n} из {arr.Length} - {arr[n - 1]} ", arr, n);
        GetNumber($"Шаг {n} из {arr.Length} ", arr, n);
        return 0;
    }

    public static int CountGreatZero(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) { count += 1; }
        }
        return count;
    }

    public static string PrintArray(int[] arr)
    {
        string s = string.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != arr.Length - 1) { s = s + $"{Convert.ToString(arr[i])} , "; } else { s = s + $"{Convert.ToString(arr[i])}"; };
        }
        return s;
    }

}