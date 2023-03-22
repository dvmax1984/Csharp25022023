/* int[,] pic = new int[10, 10];

for (int i = 0; i < 10; i++)
{
    pic[0, i] = i;
    pic[i, 0] = i;
    pic[i, 9] = i;
    pic[9, i] = i;
}

PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);


void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i,j]} ");
            if (image[i, j] == 0) Console.Write($" ");
            //else Console.Write($"+");
            else Console.Write($"{image[i, j]}");
        }
        Console.WriteLine();
    }

}
 */