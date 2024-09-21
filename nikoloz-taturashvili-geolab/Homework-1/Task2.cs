#if TASK2_1
Console.Write("Enter an integer: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} is even");
} else
{
    Console.WriteLine($"{num} is odd");
}
#endif