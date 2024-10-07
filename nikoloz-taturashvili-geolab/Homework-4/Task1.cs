namespace nikoloz_taturashvili_geolab.Homework_4;

internal class Person
{
    public string Name { get; init; }
    private int _age;
    public int Age
    {
        get => _age;
        init
        {
            _age = value switch
            {
                < 0 => 0,
                > 120 => 120,
                _ => value
            };
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person()
    {
        Name = "";
        Age = 0;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public static class Task1
{
    public static void Run()
    {
        var person = new Person
        {
            Name = "Nikoloz Taturashvili",
            Age = 29
        };
        person.GetInfo();
    }
}