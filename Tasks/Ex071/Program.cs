using static Method;

Console.WriteLine("\n Вычисление функции Аккермана с помощью рекурсии.\n");

ulong  m = GetNumber("Введите число m: ");
ulong  n = GetNumber("Введите число n: ");

Console.WriteLine($"\n Результат вычисления функции Аккермана A({m}, {n}) = " + A(m, n));