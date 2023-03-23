// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

using static MethodsSort;

Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

int[,] array = new int[4, 4] {   {4,3,6,2},
                                {1,5,8,9},
                                {5,8,3,6},
                                {8,5,2,7}};

Console.Write(PrintArray(array));

array = SortArrayDesc(array);

Console.Write(PrintArray(array));

