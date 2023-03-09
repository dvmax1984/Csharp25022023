using static Methods;

Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

int arrlenght = new Random().Next(9, 19);
int[] array = new int[arrlenght];

FillArray(array);

Console.WriteLine("В массиве четных числел: " + GetResult(array));