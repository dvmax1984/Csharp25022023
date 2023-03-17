/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

using static classFillArray;
using static classGetNumber;
using static classCheckArray;
using static classPrintArray;

Console.WriteLine("Программа, на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Массив задан 10x10, индекс массива начинается с 0");
Console.WriteLine();
  
int row = GetNumber("Задайте индекс ячейки массива, Строка  m : ");
int col = GetNumber("Задайте индекс ячейки массива, Колонка n : ");

int[,] array = new int[10, 10];

array = FillArray(array);

Console.WriteLine(CheckArray(array, row, col));

Console.WriteLine();
PrintArray(array);

