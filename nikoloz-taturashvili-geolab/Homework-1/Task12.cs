namespace nikoloz_taturashvili_geolab.Homework_1
{
    public class Task12
    {
        public static void Run()
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (!(age >= 0 && age <= 120)) //oldest living person is 116yo
            {
                Console.WriteLine("Invalid age");
                return;
            }
            else if (age < 18)
            {
                Console.WriteLine("You are not allowed to take out a loan (reason: underage)");
                return;
            }

            Console.WriteLine("What is your minimum annual income?");
            decimal income = decimal.Parse(Console.ReadLine());

            if (income >= 25000)
            {
                Console.WriteLine("You can take out a loan");
            }
            else
            {
                Console.WriteLine("Do you have a surety? (y/n)");
                bool answer = (Console.ReadLine() == "y") ? true : false;

                if (answer)
                {
                    Console.WriteLine("You can take out a loan via suretyship");
                }
                else
                {
                    Console.WriteLine("You can not take out a loan");
                }
            }
        }
    }
}