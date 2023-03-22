using static MethodsHelix;

Console.WriteLine("Задача 62, заполнить массив 4х4 по спиралью числами от 1 до 16");

int rowP = 4;
int colP = 4;
int count = 1;

int[,] array = new int[rowP, colP];

array = FillArrowHelix(rowP, colP, count, array);

PrintArray(array);