using static Library;

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

int[] arrNumber = new int[9];

int count = GetNumber("Введите несколько чисел M:> ", arrNumber, 1);

int x = CountGreatZero(arrNumber);

Console.WriteLine($"Введенные числа :  {PrintArray(arrNumber)}");

Console.WriteLine($"Введено чисел больше 0 :  {x}");