internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

        Console.Write("Введите число А = ");
        string inputA = Console.ReadLine();

        Console.Write("Введите число B = ");
        string inputB = Console.ReadLine();

        Console.Write("Введите число C = ");
        string inputC = Console.ReadLine();

        int a, b, c;

        int.TryParse(inputA, out a);
        int.TryParse(inputB, out b);
        int.TryParse(inputC, out c);

        // Решим задачу через метод

        int max = Max(a, b, c);
        Console.WriteLine("Наибольшее число " + max);
       

       
        int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;
            if (arg2 > result) result = arg2;
            if (arg3 > result) result = arg3;
            return result;
        }

    }
}