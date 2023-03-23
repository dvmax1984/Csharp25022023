public static class MethodsSort
{
    public static int[,] SortArrayDesc(int[,] array)
    {
        for (int n = 0; n < array.GetLength(0); n++)
        {
            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                int minValue = i;
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    if (array[n, j] > array[n,minValue])
                    {
                        minValue = j;
                    }
                }
                int tmp = array[n, minValue];
                array[n, minValue] = array[n, i];
                array[n, i] = tmp;
            }
        }
        return array;
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
