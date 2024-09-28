namespace nikoloz_taturashvili_geolab.Homework_1
{
    public class Task11
    {
        public static void Run()
        {
            Console.WriteLine("Where are you from?");
            string country = Console.ReadLine().ToLower();

            int requiredAge = 18;
            if (country == "usa" || country == "us" || country == "united states" ||
                country == "united states of america")
            {
                requiredAge = 21;
            }

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (!(age >= 0 && age <= 120)) //oldest living person is 116yo
            {
                Console.WriteLine("Invalid age");
                return;
            }

            if (age < requiredAge)
            {
                Console.WriteLine("You are not allowed to purchase this product");
            }
            else
            {
                Console.WriteLine("You can purchase this product");
            }
        }
    }
}