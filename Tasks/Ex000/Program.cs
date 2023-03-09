internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача № 0. Вывести квадрат числа");

        Console.Write("Введите число для возведения его в квадрат (степень 2): ");
        //string inputA = Console.ReadLine();
        //int A;
        //int.TryParse(inputA, out A);

        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{{0}} в квадрате = {{1}} ", x, Math.Pow(x, 2));   // x^2
    }
}