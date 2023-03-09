public static class Methods
{
    public static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 999);
        }
    }

    public static int GetResult(int[] arr)
    {
        int res;
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