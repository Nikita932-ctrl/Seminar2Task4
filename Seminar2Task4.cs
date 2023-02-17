
// Эта часть кода робить , как надо не хочет ,дайте подсказку ,почему ,пожалуйста),выдаётся другое число

Console.WriteLine("Введите день недели: ");
int days = Convert.ToInt32(Console.ReadLine()); //Изменил  Console.Read() на Console.ReadLine() и все заработало,почему так ,не подскажете? :)
int i = 0;
while (true)
{
    if (days == 0)
    {
        break;
    }
    else if (days > 5)
    {
        Console.WriteLine($"День недели {days} выходной");
        break;

    }
    else if (days <= 5)
    {
        Console.WriteLine($"День недели {days} не выходной");
        break;
    }
}


string daysOfWeekend (int days)
{

    if (days > 5)
    {
        Console.WriteLine($"День недели {days} выходной");


    }
    else if (days <= 5)
    {
        Console.WriteLine($"День недели {days} не выходной");

    }
    else if (days < 1 && days > 7)
    {
        Console.WriteLine("Нет такого дня недели");
    }
    return "end";


}

daysOfWeekend (0);
