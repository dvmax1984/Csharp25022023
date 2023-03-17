
public static class classGetAverageCol
{
    public static double[,] GetAverageCol(double[,] array)    // Среднее арифметическое каждого столбца
    {
        double[,] result = new double[1, array.GetLength(1)];
              
        for (int i = 0; i < 5; i++)          // Ряды    5
        {
            for (int j = 0; j < 6; j++)      // Колонки 6 array.GetLength(1)-1
            {
                result[0,i] = result[0,i] + array[j,i];
            }
            
            //result[0,i] = result[0,i] / array.GetLength(1);
        }
      
        return result;
    }
}