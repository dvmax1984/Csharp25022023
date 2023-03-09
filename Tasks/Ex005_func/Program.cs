Console.WriteLine("Задача 5. Написать программу вычисления значения функции y = f(a) - находим sin");

Console.WriteLine("Введите число y");
double a = (double)inputValue();

Console.WriteLine("Результат функции y = f(a) - (находим sin) = " + f(a) + " rad");

double f(double a)
{
    double result = Math.Sin(a);
    return result;
}


double inputValue() // специально из видеозаписи семинара скопировал, для разбора
{
    double result;
    while(!double.TryParse(Console.ReadLine(), out result));
    return result;
}