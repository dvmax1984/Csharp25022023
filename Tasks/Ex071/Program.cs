using static Library;

Console.WriteLine("71. Написать программу вычисления функции Аккермана A(n, m)");

int n = GetNumber("Введите число n: ");
int m = GetNumber("Введите число m: ");

Console.WriteLine($"Результат вычисления функции Аккермана A({n}, {m}) = " + A(n, m));