#if TASK6_1
double[] numbers = new double[3];
double max;
Console.Write("Enter number 1: ");
max = double.Parse(Console.ReadLine());
numbers[0] = max;

Console.Write("Enter number 2: ");
max = double.Parse(Console.ReadLine());
numbers[1] = max;

Console.Write("Enter number 3: ");
max = double.Parse(Console.ReadLine());
numbers[2] = max;

max = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"Maximum number is - {max}");
#endif