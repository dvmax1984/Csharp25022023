

int size = 4; //Convert.ToInt32(Console.ReadLine());

int[,] pic = new int[size, size];

int limX = pic.GetLength(0)-1;
int limY = pic.GetLength(1)-1;

for (int i = 0; i < limX; i++)
{
     pic[0, i] = 0;
     pic[i, 0] = 0;
     pic[i, limY] = 0;
     pic[limX, i] = 0;
}


          



PrintImage(pic);
FillImage(0, 0, 1, 0);
Console.WriteLine();
PrintImage(pic);

void FillImage(int row, int col, int count, int dir)
{
    if (pic[row, col] ==0)
   {
        pic[row, col] = count;

        if (col < limX && pic[row, col+1] ==0 && dir !=8)   FillImage(row, col+1, count+=1, 0);    //  > 6 Ok!

        if (row >= 0 && row != limY)    FillImage(row+1, col, count+=1, 0);    //  v 5 Ok!  || pic[row+1, col] == 0 && dir !=8)

        if (row == limY-1 && pic[row, col-1] == 0 )           FillImage(row, col-1, count+=1, 0);    //  < 4
        //if (row == limY || pic[row+1, col] == 0 )           FillImage(row, col-1, count+=1, 0);    //  < 4

        //if (col ==0 || pic[row, col-1] == 0 )               FillImage(row-1, col, count+=1,1);    //  > 6       
    }
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] > 0 && image[i, j] <= 9) Console.Write($"  {image[i,j]}");
            else Console.Write($" {image[i, j]}");
        }
        Console.WriteLine();
    }
}