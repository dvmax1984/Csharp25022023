Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

double GetNumber(string s)
{
    Console.Write(s);
    double result;
    while(!double.TryParse(Console.ReadLine(), out result));
    return result;
}

double GetResult(double a, double b)
{
    return Math.Pow(a, b);
}

double a = GetNumber("Введите число A возводимое в степерь: ");
double b = GetNumber("Введите число B степерь числа A: ");

Console.WriteLine(GetResult(a, b));
