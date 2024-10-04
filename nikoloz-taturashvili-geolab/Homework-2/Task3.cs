namespace nikoloz_taturashvili_geolab.Homework_2;

public class Task3
{
    public static void Run()
    {
        var condition = true;
        do
        {
            Console.Write("Please enter a positive number less than 10 to continue code: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number is < 1 or > 10)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                condition = false;
            }
        } while (condition);

        var count = 0;
        Console.WriteLine("We will ask you whether or not you want to continue 3 times");
        do
        {
            Console.Write("Do you want to continue? (y/n) : ");
            var answer = Console.ReadLine()?.ToLower();
            if (answer == "n")
            {
                break;
            }
            else
            {
                count++;
            }
        } while (count < 3);
        
        var response = (count == 3) ? "You continued code" : "You didn't continue code";
        Console.WriteLine(response);
    }
}