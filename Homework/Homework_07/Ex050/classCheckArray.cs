
public static class classCheckArray
{
    public static string CheckArray(int[,] arr, int row, int col)
    {
      string result;

      if (row > arr.GetLength(0) || col > arr.GetLength(1))
      {
        result = $"Элемент в ряде {row}, колонке {col} не существует, указаный адрес находится вне массива";
        return result;
      }
      
      result = $"В ряде {row} колонке {col} находиться значение {Convert.ToString(arr[row, col])}";
      return result;   
    }
}