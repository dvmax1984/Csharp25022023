using static Library;

Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

double a = GetNumber("Введите число A возводимое в степерь: ");
double b = GetNumber("Введите число B степерь числа A: ");

Console.WriteLine(GetResult(a, b));
