public static class Library
{
    public static int GetNumber(string s, int[] arr, int n)
    {
        Console.Write(s);

        if (n == arr.Length) 
        {
          Console.WriteLine();
          return 0;
        }

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        arr[n] = result;
        n += 1;
        //GetNumber($"Шаг {n} из {arr.Length} - {arr[n - 1]} ", arr, n);
        GetNumber($"Шаг {n} из {arr.Length} ", arr, n);
        return 0;
    }

  public static int CountGreatZero(int[] arr)
  {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] > 0) {count += 1;}
    }
    return count;
  }
}