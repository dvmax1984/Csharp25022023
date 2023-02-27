Console.WriteLine("**Задача 15:** Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

int ReadNumber(string text)
{
    Console.Write(text);
    int result;
    while(!int.TryParse(Console.ReadLine(), out result));
    return result;
}

bool CheckDayWeek(int d)
{
    return (d >= 1 && d <= 7);
}

bool CheckDayWeekEnd(int d)
{
    return (d == 6 || d == 7);
}

string GetResult(bool dNum, bool dayWeekEnd)
{
    if (dNum && dayWeekEnd) 
    {
        return "Да, является";
    }
    else if (dNum && !dayWeekEnd)
    {
        return "Нет, не явлется выходным днем";
    }
    else
    {
        return "Допускается ввод только чисел от 1 до 7";
    }
}

int dNum = ReadNumber("Введите номер дня недели: ");
bool flagDayWeek = CheckDayWeek(dNum);
bool flagDayWeekEnd = CheckDayWeekEnd(dNum);
string output = GetResult(flagDayWeek, flagDayWeekEnd);
Console.WriteLine(output);