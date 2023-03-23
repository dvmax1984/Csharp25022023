public static class Methods
{
    public static void FillArray(double[] arr)
    {
        Console.WriteLine($"Одномерный массив, заполненный случайными вещественными числами 1 до 9 произвольной длинной от 3 до 9, сейчас длинна = {{0}}", arr.Length);

        Console.Write("[ ");

        for (int i = 0; i < arr.Length; i++)
        {
            double rnd = new Random().NextDouble() * 9.0;
            arr[i] = Math.Round(rnd, 2);

            if (i != arr.Length - 1)
            {
                Console.Write(arr[i] + ", ");
            }
            else
            {
                Console.Write(arr[i] + " ]");
            }

        }
        Console.WriteLine();
    }

    public static double GetResult(double[] arr)
    {
        int min = 0;
        int max = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] > arr[max])
            {
                max = j;
            }
            
            if (arr[j] < arr[min])
            {
                min = j;
            }
        }
        double result = arr[max] - arr[min];
        return Math.Round(result, 2);
    }
}