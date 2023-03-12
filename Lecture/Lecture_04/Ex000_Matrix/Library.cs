public static class Library
{
    public static void PrintArray(int[,] arr, int x, int y, int turnCW)
    {
        
        
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] == 0)
                {
                    Console.SetCursorPosition(row+x ,col+y);
                    Console.Write("  ");
                }
                else
                {
                    Console.SetCursorPosition(row+x ,col+y);
                    Console.Write("■ ");
                }
                // Console.Write($"{arr[row, col] }");
            }
            Console.WriteLine();
        }
    }

    public static int[,] ArrRotate90(int[,] arr)
    {
        int rowEnd = arr.GetLength(0) - 1;
        int colEnd = arr.GetLength(1) - 1;
        int[,] arrRot2 = new int[arr.GetLength(0), arr.GetLength(1)];

        for (int row = 0; row <= arr.GetLength(0) - 1; row++)
        {
            rowEnd = arr.GetLength(0)-1;
            for (int col = 0; col <= colEnd; col++)
            {
                arrRot2[row, col] = arr[rowEnd, row];

                //Console.WriteLine($"arrRot2 = {arrRot2[row, col]} << arr = {arr[row, col]}");
                //Console.WriteLine($"rowEnd = {rowEnd}");
                rowEnd = rowEnd - 1;
                //Console.WriteLine($"rowEnd = {rowEnd}");
                //Console.WriteLine($"col = {col}");
                //Console.WriteLine($"row = {row}");
            }
        }
        return arrRot2;
    }
}