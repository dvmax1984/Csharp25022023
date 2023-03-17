// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using static classFillArray;
using static classPrintArray;
using static classGetNumber;

Console.WriteLine("Задать двумерный массив размером m×n, заполненный случайными вещественными числами (-99,9 до 99,9)");

int m = GetNumber("Задайте размер массива, кол-во Строк m : ");
int n = GetNumber("Задайте размер массива, кол-во Колонок n : ");

double[,] array = new double[m, n];

array = FillArray(array);

PrintArray(array);

Console.WriteLine();