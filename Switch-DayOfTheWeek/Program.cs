// Program finds the day of the week. ＞︿＜

int WeekDay = 10; // Convert.ToInt32(DateTime.Now.DayOfWeek);

// Value 0 - 6 that will be cheked.

switch (WeekDay)

// case 0: == if (WeekDay == 0);

{
    case 0:
        Console.WriteLine("Today is Sunday.");
        break;
    case 1:
        Console.WriteLine("Today is Monday.");
        break;
    case 2:
        Console.WriteLine("Today is Tueday.");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday.");
        break;
    case 4:
        Console.WriteLine("Today is Thursday.");
        break;
    case 5:
        Console.WriteLine("Today is Friday.");
        break;
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    default:
        Console.WriteLine("Go back to sleep!");
        break;
}

Console.WriteLine("Good night!");