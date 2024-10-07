namespace nikoloz_taturashvili_geolab.Homework_4;

internal enum Currency { Gel, Usd, Eur }

internal class Product
{
    private string Name { get; }
    private readonly decimal _price;

    private decimal Price
    {
        get => _price;
        init
        {
            _price = value switch
            {
                < 0 => 0,
                _ => value,
            };
        }
    }

    private Currency Currency { get; }

    public Product(string name, decimal price, Currency currency)
    {
        Name = name;
        Price = price;
        Currency = currency;
    }

    public void Print()
    {
        Console.WriteLine($"{Name}: {Price} {Currency}");
    }
}

public static class Task3
{
    public static void Run()
    {
        var product = new Product("Jelly Bean", 6, Currency.Gel);
        product.Print();
    }
}