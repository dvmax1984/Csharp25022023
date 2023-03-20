using static clPascalTriangle;

Console.WriteLine("Треугольник Паскаля, до 30 строк, если выше, то нужно придумать форматировать числа до 4 знаков, k, M, G, T");

int heigth = GetNumber("Введите высоту треугольника, строк: ");

int[,] arr = new int[heigth, heigth*3];

int[,] arrPasc = FillArray(arr, 3, heigth);

PrintArray(arrPasc);

Console.WriteLine();

int[,] arrMove = MoveArray(arrPasc, heigth);

PrintArray(arrMove);