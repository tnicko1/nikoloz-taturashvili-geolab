#if TASK3_1
Console.Write("Enter your score(0-100): ");
double score = double.Parse(Console.ReadLine());
char grade = ' ';


if (score > 100 || score < 0)
{
    Console.WriteLine("Invalid Score");
    return;
} else if (score >= 90)
{
    grade = 'A';
} else if (score >= 80)
{
    grade = 'B';
} else if (score >= 70)
{
    grade = 'C';
} else if (score >= 60)
{
    grade = 'D';
} else
{
    grade = 'F';
}

Console.WriteLine($"Your grade is - {grade}");
#endif