// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using static classFillArray;
using static classPrintArray;
using static classGetAverageCol;

Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Массив задан 5x6");
Console.WriteLine();
  
double[,] array = new double[5, 6];
array = FillArray(array);

Console.WriteLine(array.GetLength(0)); // Ряды
Console.WriteLine(array.GetLength(1)); // Колонки
  

PrintArray(array);

Console.WriteLine();

double[,] ar = new double[array.GetLength(0), array.GetLength(1)]; 

Console.WriteLine("987965");

ar = GetAverageCol(array);
  
Console.WriteLine("Gtxfnm");
  
PrintArray(ar);