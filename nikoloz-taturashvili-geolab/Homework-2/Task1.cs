namespace nikoloz_taturashvili_geolab.Homework_2;

public class Task1
{
    public static void Run()
    {
        Console.WriteLine("Numbers from 1 to 100:");
        for (var i = 0; i < 100; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("\n\nEven numbers from 1 to 50:");
        for (var i = 0; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}