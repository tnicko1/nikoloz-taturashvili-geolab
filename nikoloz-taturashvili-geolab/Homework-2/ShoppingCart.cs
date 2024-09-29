namespace nikoloz_taturashvili_geolab.Homework_2;

public class ShoppingCart
{
    public static void Run()
    {
        var count = 1;
        var fullPrice = 0m;
        while (true)
        {
            Console.WriteLine($"Please enter price of product {count}: ");
            var price = Convert.ToDecimal(Console.ReadLine());
            if (price < 0)
            {
                Console.WriteLine("Price cannot be negative");
                continue;
            }
            fullPrice += price;
            Console.Write("Do you want to add more products? (y/n): ");
            var input = Console.ReadLine()?.ToLower();
            if (input is "y" or "yes")
            {
                count++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"\nThe total price of your products is: {fullPrice}");
    }
}