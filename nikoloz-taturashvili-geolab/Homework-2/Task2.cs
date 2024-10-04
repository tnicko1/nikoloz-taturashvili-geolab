namespace nikoloz_taturashvili_geolab.Homework_2;

public class Task2
{
    public static void Run()
    {
        var count = 1;
        var sum = 0;
        while (count <= 50)
        {
            sum += count;
            count++;
        }

        Console.WriteLine($"Sum of numbers from 1 to 50: {sum}");

        count = 0;
        sum = 0;
        while (count < 5)
        {
            Console.Write($"Enter number {count + 1}: ");
            var number = Convert.ToInt32(Console.ReadLine());
            sum += number;
            count++;
        }

        Console.WriteLine($"Sum of your provided numbers: {sum}");
    }
}