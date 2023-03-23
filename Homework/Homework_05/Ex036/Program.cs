using static Methods;

Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

int arrlenght = new Random().Next(9, 19);
int[] array = new int[arrlenght];

FillArray(array);

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + GetResult(array));