// Сумма по главной диагонали массива

int[,] arr;

arr = new int[,]
                    {   {1,2,3},
                        {4,5,6},
                        {7,8,9} };
int sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    sum = sum + arr[i,i];       // 0, 0 = 1  // 1,1 = 5 // 2,2 = 9 
}

Console.WriteLine(sum);
