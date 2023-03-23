//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

//Массив размером 2 x 2 x 2
/*      66(0,0,0) 25(0,1,0)
        34(1,0,0) 41(1,1,0)
        27(0,0,1) 90(0,1,1)
        26(1,0,1) 55(1,1,1)*/

using static class clMethod;

Console.WriteLine("Hello, World!");

int[,,] array = new int[2,2,2];  //row - r, col - c, block - b


for (int b = 0; b < array.GetLegth(3); b++)
  {
  for (int r = 0; r < array.GetLegth(0), r++)
    {
      for (int c = 0; c < array.GetLegth(1), c++)
        {
          int value2check = new rnd.Next(10,99);
          if (CheckIsNotValueInArray(value2check, array)) 
          {
            array[r,c,b] = value2check;
          }
        }
    }
  }

Console.Write(PrintArray3D(array));