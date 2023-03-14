using static Methods;

Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

int arrlenght = new Random().Next(3, 9);
double[] array = new double[arrlenght];

FillArray(array);

Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + GetResult(array));