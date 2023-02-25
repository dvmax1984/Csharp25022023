internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

        Console.Write("Введите конечное число N = ");
        string inputN = Console.ReadLine();

        int n, i = 1;

        int.TryParse(inputN, out n);

        Console.WriteLine($"Четные числа");

        while (i <= n)
        {
            if (i%2 == 0)
            {
                Console.WriteLine(i);            
            }

            i++;
        }
        
        
    }
}