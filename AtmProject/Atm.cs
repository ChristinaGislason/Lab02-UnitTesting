using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        public static decimal Balance = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your ATM");     
            RunATM();
        }

        public static void RunATM()
        {
            bool action = true;
            while (action)
            {
                Console.WriteLine("Please select option 1, 2, 3, or 4?");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                int optionChosen = Convert.ToInt32(Console.ReadLine());

                decimal amount;
                switch (optionChosen)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is ${Balance}");
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to deposit?");
                        Decimal.TryParse(Console.ReadLine(), out amount);
                        if (Deposit(amount))
                        {
                            Console.WriteLine($"Your new balance is ${Balance}.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot make deposit. Try again.");
                        }
                        break;
                    case 3: 
                        Console.WriteLine("How much would you like to withdraw?");
                        Decimal.TryParse(Console.ReadLine(), out amount);
                        if (Withdraw(amount))
                        {
                            Console.WriteLine($"Your new balance is ${Balance}.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot make withdrawal. Try again.");
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;                     
                    default:
                        Console.Write("Invalid option. Please choose an option.");                    
                        break;    
                }

                Console.Write("Continue with another transaction?");
                Console.WriteLine("Y/N");
                string answer = Console.ReadLine();
                if (answer != null && answer.ToLower() == "n")
                {
                    Console.WriteLine("Thank you for visiting today!");
                    action = false;
                }
            }
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static bool Deposit(decimal amount)
        {
            // only deposit if amount is positive
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public static bool Withdraw(decimal amount)
        {
            // only withdraw amount if it results in 
            // balance being greater than zero
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }       

        // add method to set the balance to anything
        public static void UpdateBalance(decimal newBalance)
        {
            Balance = newBalance;
        }
    }
}
