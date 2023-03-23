public static class MethodCheck
{
    public static int[,,] FillArrayUniqValue(int[,,] array)
    {
        for (int b = 0; b < array.GetLength(2); b++)
        {
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    //int value2check = 0;// new Random().Next(10, 18);

                    bool ValisUnique;
                    do
                    {
                        array[r, c, b] = new Random().Next(10, 99);
                        ValisUnique = true;

                        // если найдено проверяемое значение, то оно не уникально
                        if (CheckIsValueInArray(array[r, c, b], array))
                        {
                            ValisUnique = false;
                            break;
                        }
                    } while (!ValisUnique);
                }
            }
        }
        return array;
    }

    public static bool CheckIsValueInArray(int checkValue, int[,,] array)
    {
        for (int b = 0; b < array.GetLength(2); b++)
        {
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    // если найдено проверяемое значение, то вернуть TRUE и выйти из циклов
                    if (checkValue == array[r, c, b])
                    {
                        //Console.WriteLine($"есть такое {checkValue} в ячейке: {r}, {c}, {b}");
                        return true;
                    }
                    else
                    {
                        //Console.WriteLine($"нет такого");
                        return false;
                    }

                }
            }
        }
        return false;
    }

    public static string PrintArray3D(int[,,] array)
    {
        string result = String.Empty;

        for (int b = 0; b < array.GetLength(2); b++)
        {
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    result += $" {array[r, c, b]}({r},{c},{b})";
                }
                result += $"\n";
            }
            result += $"\n";
        }
        return result;
    }
}