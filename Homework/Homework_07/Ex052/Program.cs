// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using static classFillArray;
using static classPrintArray;
using static classGetAverageCol;

Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Массив задан 5x6");
Console.WriteLine();
  
double[,] array = new double[5, 6];
array = FillArray(array);

PrintArray(array);

Console.WriteLine();
Console.Write("Среднее по столцам: ");  

double[,] ar = new double[array.GetLength(0), array.GetLength(1)]; 

PrintArray(GetAverageCol(array));