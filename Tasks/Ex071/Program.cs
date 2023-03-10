using static Library;

Console.WriteLine("71. Написать программу вычисления функции Аккермана A(n, m)");

ulong n = GetNumber("Введите число n: ");
ulong m = GetNumber("Введите число m: ");

Console.WriteLine($"Результат вычисления функции Аккермана A({n}, {m}) = " + A(n, m));