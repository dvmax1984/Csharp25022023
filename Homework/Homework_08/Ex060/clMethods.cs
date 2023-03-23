public class clMethod
{
    public static bool CheckIsValueInArray(int checkValue, int[,,] array)
    {
        bool result = true;

        for (int b = 0; b < array.GetLength(3); b++)
        {
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    // если найдено проверяемое значение, то вернуть FALSE и выйти из циклов
                    if (checkValue == array[r, c, b]) { return result = false; }
                }
            }
        }
        return result;
    }

    public static string PrintArray3D(int[,,] array)
    {
        string result = String.Empty;

        for (int b = 0; b < array.GetLength(3); b++)
        {
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    result += $"{array[r, c, b]} ";
                }
                result += $"\n";
            }
        }
        return result += $"\n";
    }
}