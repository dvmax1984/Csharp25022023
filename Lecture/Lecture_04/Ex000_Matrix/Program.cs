using static Library;
using static Figures;
int NumFigure = new Random().Next(1, 7);
int[,] pic = Figure(NumFigure);

Console.Clear();
ShowMessage();

Start(pic);


