public static class Library
{
    public static void PrintArray(int[,] arr, int x, int y)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] == 0)
                {
                    Console.SetCursorPosition(row + x, col + y);
                    Console.Write("  ");
                }
                else
                {
                    Console.SetCursorPosition(row + x, col + y);
                    Console.Write("■ ");
                }
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
            rowEnd = arr.GetLength(0) - 1;
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
    
    public static void Start(int[,] pic)
{
    int offsetX = 10; // координата по Х для старта
    int turnCW = 0;
    int height = 30;

    for (int y = 1; y < height; y++)
    {
        ShowMessage();
        PrintArray(pic, offsetX, y);

        var action = Console.ReadKey();
        if (action.KeyChar == '4') { offsetX -= 1; }
        else if (action.KeyChar == '6') { offsetX += 1; }
        else if (action.KeyChar == '8' || action.KeyChar == ' ') { turnCW = 1; }

        if (turnCW == 1) { pic = ArrRotate90(pic); }
        turnCW = 0;
        Console.Clear();
    }
}
    public static void ShowMessage()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Num pad: Нажми 4 / 6 смещение в право/лево | 8 поворот");
    }

}