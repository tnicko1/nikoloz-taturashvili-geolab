#if TASK1_1
Console.Write("Enter an integer: ");
int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine($"{num} is positive");
} else if (num < 0)
{
    Console.WriteLine($"{num} is negative");
} else
{
    Console.WriteLine($"{num} equals 0");
}
#endif