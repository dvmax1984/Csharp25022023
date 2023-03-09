internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача №2, нахождение максимального числа из двух введенных");
        Console.Write("Введите число А = ");
        string inputA = Console.ReadLine();

        Console.Write("Введите число B = ");
        string inputB = Console.ReadLine();

        int A, B;

        int.TryParse(inputA, out A);
        int.TryParse(inputB, out B);

        if (A > B)
        {
            Console.WriteLine("Число A > B: " + Convert.ToString(A));
        }
        else
        {
            Console.WriteLine("Число B > A:" + Convert.ToString(B));
        }
    }
}