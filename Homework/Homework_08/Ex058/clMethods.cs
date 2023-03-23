public static class Methods
{
    public static int[,] MatrixProduct(int[,] a, int[,] b, int[,] c)
    {
        for (var i = 0; i < a.GetLength(0); i++)
        {
            for (var j = 0; j < b.GetLength(1); j++)
            {
                c[i, j] = 0;

                for (int m = 0; m < a.GetLength(1); m++)
                {
                    c[i, j] += a[i, m] * b[m, j];
                }
            }
        }   
        return c;     
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
