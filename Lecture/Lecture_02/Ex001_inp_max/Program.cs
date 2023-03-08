int Max(int args1, int args2, int args3)
{
    int result = 0;
    if (args1 > result) result = args1;
    if (args2 > result) result = args2;
    if (args3 > result) result = args3;
    return result;
}

int GetData(string s)
{
    Console.Write(s); //"Введите значение: ");
    return Convert.ToInt32(Console.ReadLine());
}

int max = Max(
   Max(GetData("Введите значение 1: "), GetData("Введите значение 2: "), GetData("Введите значение 3: ")),
   Max(GetData("Введите значение 4: "), GetData("Введите значение 5: "), GetData("Введите значение 6: ")),
   Max(GetData("Введите значение 7: "), GetData("Введите значение 8: "), GetData("Введите значение 9: "))
);

Console.WriteLine(max);