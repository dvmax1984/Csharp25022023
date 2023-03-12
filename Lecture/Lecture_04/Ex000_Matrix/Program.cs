using static Library;

int[,] pic = new int[,]   /* S змейка */
{ {1,1,0,0},   /* row 0      7, 4, 1   */
  {0,0,1,1},   /* row 1      8, 5, 2   */
  {0,0,0,0},
  {0,0,0,0} }; /* row 2      9, 6, 3   */




PrintArray(pic);

int[,] arrRot = ArrRotate90(pic);
Console.WriteLine("--- Поворот на 90 град по часовой стрелке ---");
PrintArray(arrRot);

int[,] arrRot2 = ArrRotate90(arrRot);
Console.WriteLine("--- Поворот на 180 град по часовой стрелке ---");
PrintArray(arrRot2);
