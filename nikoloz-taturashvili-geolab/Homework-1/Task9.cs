
#if TASK9_1
Console.WriteLine("What time is it?");
Console.Write("Hours: ");
int hours = int.Parse(Console.ReadLine());
if (hours > 24 || hours < 0)
{
    Console.WriteLine("Invalid time");
    return;
}
Console.Write("Minutes: ");
int minutes = int.Parse(Console.ReadLine());
if (minutes > 60 || minutes < 0)
{
    Console.WriteLine("Invalid time");
    return;
}

if (minutes == 60)
{
    minutes = 0;
    hours += 1;
}

if (hours >= 5 && hours < 12)
{
    Console.WriteLine("Good Morning");
} else if (hours >= 12 && hours < 17)
{
    Console.WriteLine("Good Afternoon");
} else if (hours >= 17 && hours < 21)
{
    Console.WriteLine("Good Evening");
} else
{
    Console.WriteLine("Good Night");
}

#endif