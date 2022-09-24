// Program finds the day of the week. ＞︿＜

int WeekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (WeekDay == 0)
{
    Console.WriteLine("Today is Sudnay.");
}
else if (WeekDay == 1)
{
    Console.WriteLine("Today is Monday.");
}
else if (WeekDay == 2)
{
    Console.WriteLine("Today is Tuesday.");
}
else if (WeekDay == 3)
{
    Console.WriteLine("Today is Wednesday.");
}
else if (WeekDay == 4)
{
    Console.WriteLine("Today is Thursday.");
}
else if (WeekDay == 5)
{
    Console.WriteLine("Today is Friday.");
}
else
{
    Console.WriteLine("Today is Saturday.");
}

Console.WriteLine("Good night!");