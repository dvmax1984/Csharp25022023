using static Library;

Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

int len = GetNumber("Укажите длинну массива");

int[] array = new int[len];

FillArray(array);

Console.Write(GetResult(array));