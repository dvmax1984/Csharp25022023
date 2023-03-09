using static Library;

Console.WriteLine("Напишите метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

int n = GetNumber("Введите конечное число N: ");
Console.WriteLine(GetResult(n));