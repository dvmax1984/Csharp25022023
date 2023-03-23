public static class classGetNumber
{
  public static int GetNumber(string s)
  {
        Console.Write(s);

        int result;

        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out result) && (result >= 0 && result <= 99))
                break;
            else
            {
                Console.WriteLine("Ввели число меньше 0 и более 99 или это не число!");
                Console.Write("Повторите ввод двух значного числа от 0 до 99: ");
            }
        }    
        return result;
  }
}
