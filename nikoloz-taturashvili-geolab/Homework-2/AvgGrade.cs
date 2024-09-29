namespace nikoloz_taturashvili_geolab.Homework_2;

public class AvgGrade
{
    public static void Run()
    {
        Console.WriteLine("Enter your grades (at least 4)");
        var count = 1d;
        var sumOfGrades = 0d;
        while (true)
        {
            Console.Write($"Enter grade {count}: ");
            var grade = Convert.ToInt32(Console.ReadLine());
            if (grade is < 0 or > 100)
            {
                Console.WriteLine("Grade out of range");
                continue;
            }
            sumOfGrades += grade;
            count++;
            if (count > 4)
            {
                Console.WriteLine("Do you want to continue? (y/n)");
                var input = Console.ReadLine()?.ToLower();
                if (input is not ("y" or "yes"))
                {
                    break;
                }
            }
        }
        
        var avgGrade = sumOfGrades / (count - 1);
        Console.WriteLine($"Average grade: {avgGrade:F2}");
        
    }
}