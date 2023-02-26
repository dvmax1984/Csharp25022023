Console.WriteLine("Задача 3. По заданному номеру дня недели вывести его название");

string[] d =  {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};


Console.WriteLine("Введите номер дня недели, от 1 до 7: ");

string dayWr = Console.ReadLine();
bool res = int.TryParse(dayWr, out int dayN);

if (res == false)       //  Проверка на ошибки
    {
        Console.WriteLine("Допускается ввод только целых чисел, от 1 до 7");
    }
else if (dayN >= 1 && dayN <=7)    
    {
        Console.WriteLine($"{{0}}-й день недели - {d[dayN-1]}", dayN);
    }
else
    {   
        Console.WriteLine($"Дня недели под номером {{0}} нет", dayN);
    }
