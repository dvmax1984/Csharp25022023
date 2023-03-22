int size = 4; //Convert.ToInt32(Console.ReadLine());

int[,] pic = new int[size, size];

int limX = pic.GetLength(0)-1;
int limY = pic.GetLength(1)-1;

// for (int i = 0; i < 4; i++)
// {
//     pic[0, i] = 0;
//     pic[i, 0] = 0;
//     pic[i, limY] = 0;
//     pic[limX, i] = 0;
// }

//PrintImage(pic);
FillImage(0, 0, 1, 6);
Console.WriteLine();
PrintImage(pic);

void FillImage(int row, int col, int count, int dir)
{
    if (pic[row, col] == 0 )
    {
        pic[row, col] = count;
        if (col < limX && (dir !=4 || dir !=8))  FillImage(row, col+1, count+=1, 0);    //  > 6
        if (row < limY && (dir !=4 || dir !=8))  FillImage(row+1, col, count+=1, 5);    //  v 5
        if (col !=0)                FillImage(row, col-1, count+=1, 4);    //  < 4

        if (col == 0 && row > 0 )  FillImage(row-1, col, count+=1, 8);    //  ^ 8        
    }
    if (row > 1  && (dir == 8 && pic[row-1, col] != 0))   FillImage(row, col+1, count+=1, 6);    //  > 6
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
