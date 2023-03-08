int Max(int args1, int args2, int args3)
{
    int result = 0;
    if (args1 > result) result = args1;
    if (args2 > result) result = args2;
    if (args3 > result) result = args3;
    return result;
}

int GetData()
{
    Console.Write("Введите значение: ");
    return Convert.ToInt32(Console.ReadLine());
}

int max = Max(
   Max(GetData(), GetData(), GetData()),
   Max(GetData(), GetData(), GetData()),
   Max(GetData(), GetData(), GetData())
);

Console.WriteLine(max);