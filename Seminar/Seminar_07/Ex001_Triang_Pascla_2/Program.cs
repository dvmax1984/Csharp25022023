using static clPascalTriangle;

Console.WriteLine("Треугольник Паскаля, до 14 строк, 15 уже хуже рисует");

int heigth = GetNumber("Введите высоту треугольника, строк: ");

int[,] arr = new int[heigth, heigth*3];

int[,] arrPasc = FillArray(arr, 3, heigth);

PrintArray(arrPasc);

Console.WriteLine();

int[,] arrMove = MoveArray(arrPasc, heigth);

PrintArray(arrMove);