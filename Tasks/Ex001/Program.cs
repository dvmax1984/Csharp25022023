    Console.WriteLine("Задача № 1. По двум заданным числам проверять является ли первое (A) квадратом второго (B)");

    Console.Write("Введите число A (число в квадрате): ");    
    double a = ReadDouble(Console.ReadLine());

    Console.Write("Введите число B, возводимое в квадрат: ");    
    double b = ReadDouble(Console.ReadLine());

    if (a == b * b)     // a == Math.Pow(b, 2)
    {
        Console.WriteLine($"Первое число А = {{0}}, является квадратом числа B = {{1}} ", a, b);
    }
    else
    {
        Console.WriteLine($"Первое число А = {{0}}, НЕ является квадратом числа B = {{1}} ", a, b);
    }


    double ReadDouble(string message)
    {
        double res = Double.Parse(message);
        return res;
    }