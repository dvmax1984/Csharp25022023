using static clPascalTriangle;

Console.WriteLine("Треугольник Паскаля, до 30 строк, с консолью на полном экране");

int heigth = GetNumber("Задайте высоту треугольника в строках: ");

int[,] arr = new int[heigth, heigth*3];

int[,] arrPasc = FillArray(arr, heigth);

PrintArray(arrPasc);

Console.WriteLine();

int[,] arrMove = MoveArray(arrPasc, heigth);

PrintArray(arrMove);