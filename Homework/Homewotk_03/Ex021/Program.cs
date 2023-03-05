Console.WriteLine("Задача 21 Напишите метод(-ы), который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Принимаем координаты точки B(x1, y1, z1)");

static double GetNumber(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

static double GetResult(double x1, double y1, double z1, double x2, double y2, double z2)
{
    // Расчетная формула
    // L = SQR ((x2 - x1)^2 + (y2 + y1)^2 - (z2 + z1)^2)

    double x = Math.Pow(x2 - x1, 2);
    double y = Math.Pow(y2 - y1, 2);
    double z = Math.Pow(z2 - z1, 2);

    double l = Math.Sqrt(x + y + z);

    return Math.Round(l, 2);
}

double x1 = GetNumber("Введите x1: ");
double y1 = GetNumber("Введите y1: ");
double z1 = GetNumber("Введите z1: ");

Console.WriteLine("----------------------------------------");
Console.WriteLine("Принимаем координаты точки B(x2, y2, z2)");

double x2 = GetNumber("Введите x2: ");
double y2 = GetNumber("Введите y2: ");
double z2 = GetNumber("Введите z2: ");

double l = GetResult(x1, y1, z1, x2, y2, z2);

Console.WriteLine("Расстояние в пространстве между точками A и B = " + l);

