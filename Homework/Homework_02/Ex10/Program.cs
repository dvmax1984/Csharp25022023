Console.WriteLine("**Задача 10:** Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

string ReadText(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

bool Check(string s)
{
    return s.Length == 3;
}

string GetResult(string s, bool check)
{
    if (check) 
    {
        return "Второй символ: " + s.Substring(1, 1);
    }
    else
    {
        return "Число должно быть трехзначным!";
    }
}

string promt = ReadText("Введите трехзначное число: ");
bool flag = Check(promt);
string output = GetResult(promt, flag);
Console.WriteLine(output);