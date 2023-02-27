Console.WriteLine("**Задача 13:** Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");


string ReadText(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

bool Check(string s)
{
    return s.Length >=3;
}

string GetResult(string s, bool check)
{
    if (check) 
    {
        return "Третья цифра: " + s.Substring(2, 1);
    }
    else
    {
        return "Третьей цифры нет в введенном числе!";
    }
}

string promt = ReadText("Введите число, длинее трех знаков: ");
bool flag = Check(promt);
string output = GetResult(promt, flag);
Console.WriteLine(output);