namespace nikoloz_taturashvili_geolab.Homework_2;

public class BankTransactions
{
    public static void Run()
    {
        var balance = 1000m;
        var debt = 0m;
        
        var fullWithdraw = 0m;
        var fullDeposit = 0m;
        
        while (true)
        {
            Console.WriteLine($"Balance: {balance}$");
            if (debt != 0)
            {
                Console.WriteLine($"Debt: {debt}$\n");
            }
            Console.Write("Withdraw or deposit (w/d): ");
            var choice = Console.ReadLine()?.ToLower();
            switch (choice)
            {
                case "w" or "withdraw":
                {
                    Console.WriteLine("How much do you want to withdraw?");
                    var amount = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();
                    if (amount > balance)
                    {
                        Console.WriteLine("Not enough balance");
                        Console.WriteLine("Do you want to overdraft? (y/n)");
                        choice = Console.ReadLine()?.ToLower();
                        Console.Clear();
                        if (choice is "y" or "yes")
                        {
                            balance -= amount;
                            debt = -balance;
                            balance = 0m;
                            
                            fullWithdraw += amount;

                            Console.WriteLine($"You have withdrawn {amount}$");
                            Display(balance, debt);
                        }
                    }
                    else
                    {
                        balance -= amount;
                        fullWithdraw += amount;
                        
                        Console.WriteLine($"You have withdrawn {amount}$");
                        Display(balance, debt);
                    }

                    break;
                }
                case "d" or "deposit":
                {
                    Console.WriteLine("How much do you want to deposit?");
                    var amount = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();
                    if (amount < 0)
                    {
                        Console.WriteLine("You cannot deposit less than 0");
                    } else if (debt != 0)
                    {
                        debt -= amount;
                        if (debt < 0)
                        {
                            balance = -debt;
                            debt = 0;
                        }
                        
                        fullDeposit += amount;

                        Console.WriteLine($"You have deposited {amount}$");
                        Display(balance, debt);
                    }
                    else
                    {
                        balance += amount;
                        fullDeposit += amount;
                        
                        Console.WriteLine($"You have deposited {amount}$");
                        Display(balance, debt);
                    }

                    break;
                }
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            ConfirmContinue(fullWithdraw, fullDeposit, balance, debt);
        }
    }

    private static void Display(decimal balance, decimal debt)
    {
        Console.WriteLine($"\nBalance: {balance}$");
        if (debt != 0)
        {
            Console.WriteLine($"Debt: {debt}$");
        }
    }

    private static void ConfirmContinue(decimal fullWithdraw, decimal fullDeposit, decimal balance, decimal debt)
    {
        Console.WriteLine("Do you want to continue? (y/n)");
        var choice = Console.ReadLine()?.ToLower();
        if (choice is "y" or "yes")
        {
            Console.Clear();
            return;
        };
        FinalDisplay(fullWithdraw, fullDeposit, balance, debt);
    }

    private static void FinalDisplay(decimal fullWithdraw, decimal fullDeposit, decimal balance, decimal debt)
    {
        Console.Clear();
        Console.WriteLine($"You have withdrawn a total of {fullWithdraw}$");
        Console.WriteLine($"You have deposited a total of {fullDeposit}$");

        Console.WriteLine($"\nCurrent Balance: {balance}$");
        if (debt != 0)
        {
            Console.WriteLine($"Current debt: {debt}$");
        }

        Console.WriteLine("Thank you for using our service.");
        Environment.Exit(0);
    }
}