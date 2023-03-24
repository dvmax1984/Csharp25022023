/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30     */

using static Method;

Console.WriteLine($"\n Программа, расчитывает сумму натуральных элементов в промежутке от M до N. \n");

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");

int sum = GetSumNatural(m, n);
int sumRec = GetSumNaturalRec(m, n);

Console.WriteLine($"\n Результат цикла:    [ {sum} ] сумма натуральных элементов в промежутке от M до N \n");
Console.WriteLine($"\n Результат рекурсии: [ {sumRec} ] сумма натуральных элементов в промежутке от M до N \n");
