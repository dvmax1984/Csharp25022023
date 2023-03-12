using static Library;
using static Figures;
int NumFigure = new Random().Next(1, 7);
int[,] pic = Figure(NumFigure);

Console.Clear();
Console.SetCursorPosition(0, 0);
Console.WriteLine("Нажми на Num pad: 4 / 6 смещение в право/лево | 8 поворот");

int offsetX = 10;
int turnCW = 0;
int height = 30;

for (int y = 2; y < height; y++)
{
    PrintArray(pic, offsetX, y, turnCW);

    var action = Console.ReadKey();

         if (action.KeyChar == '4') { offsetX -= 1; }
    else if (action.KeyChar == '6') { offsetX += 1; }
    else if (action.KeyChar == '8' || action.KeyChar == ' ') { turnCW = 1; }

    if (turnCW == 1) { pic = ArrRotate90(pic); }
    turnCW = 0;
    Console.Clear();
}

/* int[,] arrRot = ArrRotate90(pic);
Console.WriteLine("--- Поворот на 90 град по часовой стрелке ---");
PrintArray(arrRot, 10); */
