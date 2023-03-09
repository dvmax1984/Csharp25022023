Console.WriteLine("Задача 2. Даны два числа. Показать большее и меньшее число");

Console.Write("Введите число А = ");
int a = ReadInt(Console.ReadLine());

Console.Write("Введите число B = ");
int b = ReadInt(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число А = {{0}} > числа B = {{1}}", a, b);
}
else
{
    Console.WriteLine($"Число А = {{0}} < числа B = {{1}}", a, b);
}

int ReadInt(string message)
{
    int res = Int32.Parse(message);
    return res;
}
