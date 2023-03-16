using static Library;
/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. */

Console.WriteLine("Нахождение точку пересечения (X и Y) двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите значения b1, k1, b2 и k2 задаются пользователем.");

double b1 = GetNumber("Введите значения b1 :> ");
double k1 = GetNumber("Введите значения k1 :> ");
double b2 = GetNumber("Введите значения b2 :> ");
double k2 = GetNumber("Введите значения k2 :> ");

var res = GetResult(b1, k1, b2, k2);

    double x = res.x;
    double y = res.y;

Console.WriteLine($"Точка пересечения двух прямых X = {x} и Y = {y}");
