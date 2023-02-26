internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 4. Найти максимальное из трех чисел");

        int[] array = { 2, 4, 1 };

        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }            
        }

        Console.WriteLine("Максимальное число "+ max);

    }
}