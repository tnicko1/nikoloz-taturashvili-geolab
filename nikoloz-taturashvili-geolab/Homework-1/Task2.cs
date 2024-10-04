namespace nikoloz_taturashvili_geolab.Homework_1
{
    public class Task2
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}