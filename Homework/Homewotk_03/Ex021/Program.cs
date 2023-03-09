using static Library;

Console.WriteLine("Задача 21 Напишите метод(-ы), который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Принимаем координаты точки B(x1, y1, z1)");

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

