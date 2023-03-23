// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
using static Methods;

Console.WriteLine("Произведение двух матриц 2x2");

int[,] a = new int[2, 2] {  {2,4},
                            {3,2}};

int[,] b = new int[2, 2] {  {3,4},
                            {3,3}};
int[,] c = new int[2, 2];

Console.WriteLine("Матрица A");
Console.Write(PrintArray(a));

Console.WriteLine("Матрица B");
Console.Write(PrintArray(b));

c = MatrixProduct(a, b, c);

Console.WriteLine("Результирующая матрица С");
Console.Write(PrintArray(c));