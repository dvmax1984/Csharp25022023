internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

        Console.Write("Введите число А = ");
        string inputA = Console.ReadLine();

        int a;

        int.TryParse(inputA, out a);

        if (a%2 == 0)
        {
            Console.WriteLine($"Число {a} является четным");
        }
        else
        {
            Console.WriteLine($"Число {a} является нечетным");
        }

    }
}