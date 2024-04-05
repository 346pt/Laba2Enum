Console.WriteLine("Введите день недели и время дня");
Console.Write("День недели: ");
string day = Console.ReadLine();
Days InsertDay = (Days)Enum.Parse(typeof(Days), day);
Console.Write("Время: ");
int time = Convert.ToInt32(Console.ReadLine());
if (time >= 24 || time < 0)
{
    Console.WriteLine("Ошибка ввода времени");
    Environment.Exit(0);
}
Time InsertTime = GetTime(time);

Console.WriteLine($"Сегодня {InsertDay} и время дня {InsertTime}");

static Time GetTime(int time)
{
    if (time >= 0 && time <= 6)
    {
        return Time.Night;
    }
    else if (time >= 7 && time <= 10)
    {
        return Time.Morning;
    }
    else if (time >= 11 && time <= 15)
    {
        return Time.Noon;
    }
    else if (time >= 16 && time <= 18)
    {
        return Time.Afternoon;
    }
    else
    {
        return Time.Evening;
    }
}

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Time
{
    Morning,
    Noon,
    Afternoon,
    Evening,
    Night
}