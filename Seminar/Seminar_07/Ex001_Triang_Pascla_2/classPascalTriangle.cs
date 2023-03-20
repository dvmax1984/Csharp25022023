public static class clPascalTriangle
{
    /// <summary>
    /// Метод FillArray() заполняет массив по формуле треугольника Паскаля
    /// </summary>
    /// <param name="arr">Аргумент FillArray() сообщает массив для заполнения</param>
    /// <param name="sc">Аргумент FillArray() сообщает шаг</param>
    /// <param name="height">Аргумент FillArray() сообщает высоту треугольника в строках</param>
    public static int[,] FillArray(int[,] arr, int sc, int height)
    {
        arr[0, 0] = 1; arr[1, 0] = 1; arr[1, sc] = 1;

        for (int i = 2; i < arr.GetLength(0); i++)              // row
        {
            for (int j = 0; j < arr.GetLength(1); j += sc)      // col
            {
                if (j == 0) { arr[i, j] = 1; }
                else { arr[i, j] = arr[i - 1, j - sc] + arr[i - 1, j]; }
            }
        }

        return arr;
    }

    /// <summary>
    /// Метод MoveArray() центрирует треугольник Паскаля в самом массиве.
    /// Начало центрирования с основания треугольника
    /// Массив сдвигается в право, пример: 11>>0 , 10>>11 , 9>>10 , 8>>9 итд
    /// </summary>
    public static int[,] MoveArray(int[,] arr, int height)
    {
        int n = arr.GetLength(1);                        // ширина массива, колонки
        int mR = 1;                                      // сдвиг, начальный центр

        for (int row = arr.GetLength(0)-1; row >= 0; row--)
        {  
            for (int i = 0; i < mR; i++)                 // сдвиг на k
            {
                int LastVal = arr[row, n - 1];           //запомнить последнее значение последней колонки

                for (int col = n - 1; col > 0; col--)
                {
                    arr[row, col] = arr[row, col - 1];
                }
                arr[row, 0] = LastVal;
            }
            
            mR += 3; //инкремент mR по уменьшению ряда, чем меньше ряд, тем больше требуется смещение
        }

        return arr;
    }


    public static void PrintArray(int[,] a)
    {
        for (int m = 0; m < a.GetLength(0); m++)
        {
            for (int n = 0; n < a.GetLength(1); n++)
            {
                if (a[m, n] >= 1 && a[m, n] <= 9)       Console.Write($"   {a[m, n]}");
                else if (a[m, n] >= 10 && a[m, n] <= 99)     Console.Write($"  {a[m, n]}");
                else if (a[m, n] >= 100 && a[m, n] <= 999)   Console.Write($" {a[m, n]}");
                else if (a[m, n] >= 1000 && a[m, n] <= 9999) Console.Write($"{a[m, n]}");
                else if (a[m, n] >= 10000 && a[m, n] <= 99999) Console.Write($"{a[m, n]/100}k");
                else if (a[m, n] >= 100000 && a[m, n] <= 999999) Console.Write($"{a[m, n]/1000}M");
                else if (a[m, n] >= 1000000 && a[m, n] <= 9999999) Console.Write($"{a[m, n]/10000}G");
                else if (a[m, n] >= 10000000 && a[m, n] <= 99999999) Console.Write($"{a[m, n]/100000}T");
                else if (a[m, n] == 0) Console.Write($" ");
            }
            Console.WriteLine();
        }
    }

    public static int GetNumber(string s)
    {
        Console.Write(s);

        int n;
        while (!int.TryParse(Console.ReadLine(), out n)) ;
        return n;
    }
}