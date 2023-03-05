Console.WriteLine("Задача 21 Напишите метод(-ы), который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Принимаем координаты точки B(x1, y1, z1)");

Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------");
Console.WriteLine("Принимаем координаты точки B(x2, y2, z2)");

Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

// L = SQR ((x2 - x1)^2 + (y2 + y1)^2 - (z2 + z1)^2)

double x = Math.Pow(x2 - x1, 2);
double y = Math.Pow(y2 - y1, 2);
double z = Math.Pow(z2 - z1, 2);

double l = Math.Sqrt(x + y + z);

l = Math.Round(l, 2);

Console.WriteLine("Расстояние в просмтрансве между точками A и B = " + l);
