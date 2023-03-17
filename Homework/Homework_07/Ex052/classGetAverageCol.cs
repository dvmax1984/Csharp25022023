
public static class classGetAverageCol
{
    public static double[,] GetAverageCol(double[,] array)          // Среднее арифметическое каждого столбца
    {
        double[,] result = new double[1, array.GetLength(1)];
              
        for (int col = 0; col < array.GetLength(1); col++)          // Перебор Столбцов
        {
            for (int row = 0; row < array.GetLength(0); row++)      // Перебор Строк
            {
                result[0,col] = result[0,col] + array[row,col];
            }
            
            double res = result[0,col] / array.GetLength(0) ;
            result[0,col] = Math.Round(res,2);                      // сумму по столбцу делим на кол-во (длину по строкам)            
        }      
        
        return result;
    }
}