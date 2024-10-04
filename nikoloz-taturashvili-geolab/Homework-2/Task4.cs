namespace nikoloz_taturashvili_geolab.Homework_2;

public class Task4
{
    public static void Run()
    {
        var rows = 5;

        for (var i = 0; i <= rows; i++)
        {
            for (var j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}