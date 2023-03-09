using static Library;


Console.WriteLine("Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

int num = GetNumber("Введите число: ");
Console.WriteLine($"В числе {num} cумма чисел = {GetResult(num)}");