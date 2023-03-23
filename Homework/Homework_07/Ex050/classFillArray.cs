
public static class classFillArray
{
    public static int[,] FillArray(int[,] arr)
    {
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                arr[m, n] = new Random().Next(11, 99);
            }
        }
        return arr;
    }
}