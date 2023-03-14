using static Library;

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

int[] arrNumber = new int[9];

int count = GetNumber("Введите несколько чисел M:> ", arrNumber, 0, 0);

Console.WriteLine($"Count = {count} ");

for (int i = 0; i < arrNumber.Length; i++)
  {
    Console.WriteLine(arrNumber[i]);
  }