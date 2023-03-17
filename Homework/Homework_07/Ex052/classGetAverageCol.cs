
public static class classGetAverageCol
{
    public static double[,] GetAverageCol(double[,] array)    // Среднее арифметическое каждого столбца
    {
        double[,] result = new double[1, array.GetLength(1)];
              
        for (int i = 0; i < 4; i++)          // Ряды
        {
            for (int j = 0; j < 5; j++)      // Колонки
            {
                result[1,i] = result[1,j] + array[i,j] ;
            }
            
            result[0,i] = result[0,i] / array.GetLength(1);
        }
      
        return result;
    }
}