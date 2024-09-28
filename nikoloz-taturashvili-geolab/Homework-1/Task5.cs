#if TASK5_1
const string password = "secret123";
Console.Write("Enter Password: ");
string enteredPassword = Console.ReadLine();

if (enteredPassword == password)
{
    Console.WriteLine("Access Granted!");
} else
{
    Console.WriteLine("Access Forbidden!");
}
#endif