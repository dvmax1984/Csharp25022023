
public static class classFillArray
{
    public static double[,] FillArray(double[,] arr)
    {
        double maxValue = 99.9;
        double minValue = -99.9;  
      
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
              // рандомим числа от -99.9 до 99.9
              double data = new Random().NextDouble() * (maxValue - minValue) + minValue;

              arr[m, n] = Math.Round(data, 1);
            }
        }
        return arr;
    }
}