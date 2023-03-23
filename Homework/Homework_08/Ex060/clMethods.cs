public static class MethodCheck
{
  //public static int[,,] GetUniqValue(int value2check)
  //{
  //  while ()
  //}
  
  
  public static int[,,] FillArrayUniqValue(int[,,] array) 
{
for (int b = 0; b < array.GetLength(2); b++)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
         int value2check = 0;// new Random().Next(10, 18);

bool isUnique;
                do
                {
                    array[r,c,b] = random.Next(10, 20);
                    isUnique = true;
                    
                  for (int j = 0; j < i; ++j)

                    if (!CheckIsValueInArray(array[r,c,b], array))                  
                    //if (array[r,c,b] == array[r,c,b])
                        {
                            isUnique = false;
                            break;
                        }
                } while (!isUnique);
          
          
          
          //if (!CheckIsValueInArray(value2check, array))
            //{
            //    array[r, c, b] = value2check;
            //}
          //else
          //{
           // value2check = new Random().Next(10, 18);
           // }
            //while (!CheckIsValueInArray(value2check, array))
            //{
            //  array[r, c, b] = value2check;
            //}
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
                    if (checkValue == array[r, c, b]) { return true; }
                }
            }
        }
        return false;
    }

// TARGER
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*      66(0,0,0) 25(0,1,0)
        34(1,0,0) 41(1,1,0)
        27(0,0,1) 90(0,1,1)
        26(1,0,1) 55(1,1,1)    */
  
    public static string PrintArray3D(int[,,] array)
    {
        string result = String.Empty;

        for (int b = 0; b < array.GetLength(2); b++)
        {
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                  //Console.Write($" {array[r, c, b]}({r},{c},{b})");
                  result += $" {array[r, c, b]}({r},{c},{b})";
                }
            //Console.WriteLine($" ");//" row: {r}");
            result += $"\n";  
            }
          //Console.WriteLine($" ");//block: {b}");
          result += $"\n";
        }
        return result;
    }
}