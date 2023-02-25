Console.WriteLine("Задача №2, нахождение максимального числа из двух введенных");
Console.Write("Введите число А = ");
string inputA = Console.ReadLine();

Console.Write("Введите число B = ");
string inputB = Console.ReadLine();

int A, B;

Int32.TryParse(inputA, out A);
Int32.TryParse(inputB, out B);

if (A > B)
{
    Console.WriteLine("Число A > B: " + Convert.ToString(A));
}
else
{
    Console.WriteLine("Число B > A:" + Convert.ToString(B));
}