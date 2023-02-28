Console.WriteLine("Задача 6. Выяснить является ли число чётным");

int ReadNumber(string text)
{
    Console.Write(text);
    int result;
    while(!int.TryParse(Console.ReadLine(), out result));
    return result;
}

string GetResult(int n)
{
    if (n % 2 == 0) 
    {
        return "Число четное";
    }
    else
    {
        return "Число не четное";
    }
}

int n = ReadNumber("Введите целое число: ");
string output = GetResult(n);
Console.WriteLine(output);
