Console.WriteLine("15. Дано число. Проверить кратно ли оно 7 и 23");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n%7==0 || n%23==0)
{
    Console.Write("делится");   
}
else 
{
   Console.Write("не делится "); 
}

