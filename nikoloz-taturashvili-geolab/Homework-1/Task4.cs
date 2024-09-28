namespace nikoloz_taturashvili_geolab.Homework_1
{
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a number to check if it is a leap year or not");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}