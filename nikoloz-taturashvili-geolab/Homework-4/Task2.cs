namespace nikoloz_taturashvili_geolab.Homework_4;

internal class Car
{
    private string Brand { get; }
    private string Model { get; }
    private readonly int _year;

    private int Year
    {
        get => _year;
        init
        {
            if (value < 1886)
                _year = 1886;
            else if (value > DateTime.Now.Year)
                _year = DateTime.Now.Year;
            else
                _year = value;
        }
    }

    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void Print()
    {
        Console.WriteLine($"{Brand} {Model} {Year}");
    }
}

public static class Task2
{
    public static void Run()
    {
        var car = new Car("Audi", "RS7 Sport-back", 2024);
        car.Print();
    }
}