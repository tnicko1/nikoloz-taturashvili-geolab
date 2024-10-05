namespace nikoloz_taturashvili_geolab.Homework_3;

internal class Product(string name, decimal price, int quantity)
{
    private string Name { get; } = name;
    private decimal Price { get; } = price;
    private int Quantity { get; } = quantity;
    public decimal TotalPrice => Price * Quantity;

    public void DisplayWithTotal()
    {
        Console.WriteLine($"{Name,-30}\t{Price,5:C0}\t{Quantity,5}\t{TotalPrice,17:C0}");
    }
}

public class Task2
{
    public static void Run()
    {
        Console.Write("How many products do you have: ");
        var count  = Convert.ToInt32(Console.ReadLine());
        var products = ProductGenerator.GetProducts(count);

        Console.Clear();
        Console.WriteLine($"{"Name",-30}\t{"Price",5}\tQuantity\tTotal Price");
        var sum = 0m;
        foreach (var product in products)
        {
            sum += product.TotalPrice;
            product.DisplayWithTotal();
        }

        Console.WriteLine($"\nTotal amount of money you have to pay: {sum:C0}");
    }
}


internal static class ProductGenerator
{
    private static readonly Random RandomNum = new();

    // Lists for generating product names
    private static readonly List<string> Adjectives =
    [
        "Premium", "Ultra", "Deluxe", "Elite", "Smart",
        "Pro", "Advanced", "Classic", "Eco", "Modern",
        "Digital", "Portable", "Wireless", "Luxury", "Essential"
    ];

    private static readonly List<string> Nouns =
    [
        "Laptop", "Phone", "Watch", "Tablet", "Camera",
        "Headphones", "Speaker", "Monitor", "Keyboard", "Mouse",
        "Charger", "Battery", "Printer", "Router", "Drive"
    ];

    private static readonly List<string> Brands =
    [
        "TechPro", "SmartLife", "InnoTech", "NextGen", "FutureX",
        "EliteWare", "DigitTech", "MaxPro", "PowerTech", "CoreTech"
    ];

    // Product name with brand
    private static string GetRandomProductNameWithBrand()
    {
        var brand = Brands[RandomNum.Next(Brands.Count)];
        var adjective = Adjectives[RandomNum.Next(Adjectives.Count)];
        var noun = Nouns[RandomNum.Next(Nouns.Count)];
        return $"{brand} {adjective} {noun}";
    }

    public static List<Product> GetProducts(int count)
    {
        var products = new List<Product>();
        for (var i = 0; i < count; i++)
        {
            var product = new Product(GetRandomProductNameWithBrand(), RandomNum.Next(200, 2000), RandomNum.Next(3, 20) );
            products.Add(product);
        }
        return products;
    }
}

