namespace nikoloz_taturashvili_geolab.Homework_3;

internal class Employee
{
    private string Name { get; }
    private int WorkedHours { get; }
    private decimal Salary { get; }
    private int OvertimeHours { get; }
    public decimal Compensation { get; }
    public bool WorkedOvertime { get; }
    
    private const int NormalWorkingHours = 8;
    private const double OverworkRate = 1.25;

    public Employee(string name, int workedHours, decimal salary)
    {
        Name = name;
        WorkedHours = workedHours;
        Salary = salary;
        if (WorkedHours > NormalWorkingHours)
        {
            OvertimeHours = WorkedHours - NormalWorkingHours;
        }

        if (WorkedHours > NormalWorkingHours)
        {
            Compensation = (WorkedHours - NormalWorkingHours) * Salary + OvertimeHours * Salary * (decimal)OverworkRate;
            WorkedOvertime = true;
        }
        else
        {
            Compensation = WorkedHours * Salary;
            WorkedOvertime = false;
        }
    }

    public void Display()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Worked hours: {WorkedHours}");
        Console.WriteLine($"Compensation: {Compensation:C0}");
    }
}
public static class Task1
{
    public static void Run()
    {
        Console.Write("How many employees do you have: ");
        var count = Convert.ToInt32(Console.ReadLine());
        var employees = Lists.RandomEmployeeList(count);
        var employeesThatWorkedOvertime = new List<Employee>();

        var sumOfCompensation = 0m;
        foreach (var employee in employees)
        {
            sumOfCompensation += employee.Compensation;
            if (employee.WorkedOvertime)
            {
                employeesThatWorkedOvertime.Add(employee);
            }
        }

        Console.Clear();
        Console.WriteLine($"Total sum of compensation that you have to pay: {sumOfCompensation:C0}");
        if (employeesThatWorkedOvertime.Count > 0)
        {
            Console.WriteLine($"\n{employeesThatWorkedOvertime.Count} Employee(s) that worked over time:");
        }
        else
        {
            Console.WriteLine("No employees that worked over time");
        }

        foreach (var employee in employeesThatWorkedOvertime)
        {
            employee.Display();
        }
    }
}

internal static partial class Lists
{
    private static readonly Random RandomNum = new Random();
    
    public static List<Employee> RandomEmployeeList(int count)
    {
        var employees = new List<Employee>();
        for (var i = 0; i < count; i++)
        {
            var employee = new Employee(GetRandomFullName(), GetWeightedNumber(), Convert.ToDecimal(RandomNum.Next(20, 100)));
            employees.Add(employee);
        }
        
        return employees;
    }
    
    private static readonly List<string> FirstNames =
    [
        "James", "John", "Robert", "Michael", "William",
        "Emma", "Olivia", "Ava", "Isabella", "Sophia",
        "David", "Joseph", "Thomas", "Charles", "Daniel",
        "Mia", "Charlotte", "Amelia", "Harper", "Evelyn"
    ];
    
    private static readonly List<string> LastNames =
    [
        "Smith", "Johnson", "Williams", "Brown", "Jones",
        "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
        "Anderson", "Taylor", "Thomas", "Moore", "Jackson",
        "Martin", "Lee", "Thompson", "White", "Harris"
    ];

    private static string GetRandomFullName()
    {
        var firstName = FirstNames[RandomNum.Next(FirstNames.Count)];
        var lastName = LastNames[RandomNum.Next(LastNames.Count)];
        return $"{firstName} {lastName}";
    }
    
    private static int GetWeightedNumber()
    {
        var rand = RandomNum.NextDouble(); // Gets a random number between 0 and 1

        return rand switch
        {
            // 70% chance for numbers 0-8
            < 0.70 => RandomNum.Next(9),
            // 20% chance for numbers 9-11
            < 0.90 => RandomNum.Next(9, 12),
            _ => RandomNum.Next(12, 25)
        };
    }
}