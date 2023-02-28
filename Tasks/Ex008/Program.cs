Console.WriteLine("8. Показать четные числа от 1 до N");

string PrintNumber(int start, int end)
{
    string s = string.Empty;
    string sep = string.Empty;

    for (int i = start; i <= end; i++)
    {
        if (i != end) {sep = ", ";} else {sep = string.Empty;}

        s+= Convert.ToString(i) + sep;
    }
    return s;
}

string s = PrintNumber(-5, 5);
Console.WriteLine(s);