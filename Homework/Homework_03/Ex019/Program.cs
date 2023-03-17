using static Library;

Console.WriteLine("Задача № 19. Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.!");

int num = GetNumber("Введите пятизначное число n: ");
bool lenghNum = CheckLenghtNumber(num);

if (lenghNum)
{
    Console.WriteLine(GetResult(num));
}
