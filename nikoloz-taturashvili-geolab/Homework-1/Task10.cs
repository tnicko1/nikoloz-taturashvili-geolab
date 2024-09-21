
#if TASK10_1
Console.Write("How much are you paying?: $");
decimal pay = decimal.Parse(Console.ReadLine());
if (pay < 0)
{
    Console.WriteLine($"You can not pay ${pay}");
    return;
}

if (pay < 100)
{
    Console.WriteLine($"You paid {pay} (no discount)");
} else if (pay <= 500)
{
    Console.WriteLine($"You paid {pay - (pay * 0.1m)} (10% discount)");
}else
{
    Console.WriteLine($"You paid {pay - (pay * 0.2m)} (20% discount)");
}
#endif