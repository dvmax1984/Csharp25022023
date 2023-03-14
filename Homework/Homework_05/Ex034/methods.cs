public static class Methods
{
    public static void FillArray(int[] arr)
    {
        Console.WriteLine($"Массив из целых положительных чисел 1 до 999 произвольной длинной от 9 до 19, сейчас длинна = {{0}}", arr.Length);

        Console.Write("[ ");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 999);
            
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

    public static int GetResult(int[] arr)
    {
        int res = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] % 2 == 0)
            {
                res = res + 1;
            }
        }
        return res;
    }
}