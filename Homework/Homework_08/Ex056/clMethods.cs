public static class Methods
{
    public static int GetIndexMin(int[] array)
    {
        int minIndex = 0;
        int minValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (minValue > array[i])
            {
                minValue = array[i];
                minIndex = i;
            }
        }
        return minIndex + 1;
    }

    public static int[] ArraySumOfRows(int[,] array, int[] sum)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum[i] += array[i, j];
            }
        }
        return sum;
    }

    public static string PrintArray(int[,] array)
    {

        string result = String.Empty;

        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                result += $"{array[m, n]} ";
            }
            result += $"\n";
        }
        return result += $"\n";
    }
}
