public static class MethodsHelix
{
    public static int[,] FillArrowHelix(int rowP, int colP, int count, int[,] array)
    {
        // заполнение периметра
        for (int y = 0; y < colP; y++)
        {
            array[0, y] = count;
            count++;
        }
        for (int x = 1; x < rowP; x++)
        {
            array[x, colP - 1] = count;
            count++;
        }
        for (int y = colP - 2; y >= 0; y--)
        {
            array[rowP - 1, y] = count;
            count++;
        }
        for (int x = rowP - 2; x > 0; x--)
        {
            array[x, 0] = count;
            count++;
        }

        // заполнение массива по спирали
        int row = 1;
        int col = 1;

        while (count < rowP * colP)
        {
            while (array[row, col + 1] == 0)        // >> 6
            {
                array[row, col] = count;
                count++;
                col++;
            }

            while (array[row + 1, col] == 0)        // v 5
            {
                array[row, col] = count;
                count++;
                row++;
            }

            while (array[row, col - 1] == 0)        // << 4
            {
                array[row, col] = count;
                count++;
                col--;
            }

            while (array[row - 1, col] == 0)        // ^ 8
            {
                array[row, col] = count;
                count++;
                row--;
            }
        }

        // Заменяем оставшийся 00 в центре крайним числом из последовтельности
        for (int x = 0; x < rowP; x++)
        {
            for (int y = 0; y < colP; y++)
            {
                if (array[x, y] == 0)
                {
                    array[x, y] = count;
                }
            }
        }

        return array;
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < 10) Console.Write($" 0{array[i, j]}");
                else Console.Write($" {array[i, j]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}