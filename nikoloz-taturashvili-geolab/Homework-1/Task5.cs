namespace nikoloz_taturashvili_geolab.Homework_1
{
    public class Task5
    {
        public static void Run()
        {
            const string password = "secret123";
            Console.Write("Enter Password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == password)
            {
                Console.WriteLine("Access Granted!");
            }
            else
            {
                Console.WriteLine("Access Forbidden!");
            }
        }
    }
}