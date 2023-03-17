public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;

    }

    public static string GetResult(int n)
    {
        string result = String.Empty;
        int index = 1;

        while (index <= n)
        {
            double cube = Math.Pow(index, 3);                          //index * index * index; 
            result = result + "(Число " + index + " в степени ^3 = " + cube + ") ";
            index++;
        }
        return result;
    }
}