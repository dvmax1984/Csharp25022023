Console.WriteLine("8. Показать четные числа от 1 до N");

string PrintNumber(int N)
{
    string s = string.Empty;
    string sep = string.Empty;

    for (int i = 1; i <= N; i++)
    {
        if (i != N) {sep = ", ";} else {sep = string.Empty;}
        if (i !%2 == 0) {s+= Convert.ToString(i) + sep;}        
    }
    return s;
}

string s = PrintNumber(10);
Console.WriteLine(s);