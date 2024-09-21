#if TASK7_1
Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter the operator(+, -, *, /): ");
string op = Console.ReadLine();


Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
} else if (op == "-")
{
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
} else if (op == "*")
{
    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
} else if (op == "/")
{
    if (num2 == 0)
    {
        Console.WriteLine("Can not divide by 0");
    } else
    {
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    }
} else
{
    Console.WriteLine("Invalid operator!");
}

#endif