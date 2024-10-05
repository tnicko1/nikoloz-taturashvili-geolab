namespace nikoloz_taturashvili_geolab.Homework_3;

internal class Sale
{
    public decimal Amount { get; init; }
    public DayOfWeek DayOfWeek { get; init; }
}

public class Task3
{
    public static void Run()
    {
        var sales = new List<Sale>();
        var continueEntering = true;

        while (continueEntering)
        {
            decimal amount;
            do
            {
                Console.Write("Enter sale amount: $");
            } while (!decimal.TryParse(Console.ReadLine(), out amount) || amount < 0);
            
            Console.WriteLine("Enter day of week (1-7, where 1 = Monday, 7 = Sunday):");
            int day;
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
            {
                Console.WriteLine("Please enter a valid day (1-7):");
            }
            
            sales.Add(new Sale 
            { 
                Amount = amount, 
                DayOfWeek = (DayOfWeek)((day + 6) % 7) // Adjust to match DayOfWeek enum (where Sunday = 0)
            });
            
            Console.Write("\nDo you want to enter another sale? (y/n): ");
            continueEntering = Console.ReadLine()?.ToLower().StartsWith("y", StringComparison.CurrentCultureIgnoreCase) ?? false;
            Console.Clear();
        }
        
        Console.WriteLine("\nSales Statistics:");
        Console.WriteLine("----------------");

        // Daily totals
        var dailyTotals = sales.GroupBy(s => s.DayOfWeek)
                              .OrderBy(g => g.Key)
                              .ToDictionary(g => g.Key, g => g.Sum(s => s.Amount));

        foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
        {
            var dayTotal = dailyTotals.GetValueOrDefault(day, 0);
            Console.WriteLine($"{day}: ${dayTotal:F2}");
        }
        
        var weeklyTotal = sales.Sum(s => s.Amount);
        Console.WriteLine("\nTotal weekly sales: ${0:F2}", weeklyTotal);
    }
}