using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        public static decimal Balance = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your ATM");
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static bool deposit(decimal amount)
        {
            // only deposit if amount is positive
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public static decimal withdraw(decimal amount)
        {
            // only withdraw amount if it results in 
            // balance being greater than zero
            if (Balance - amount >= 0)
            {
                Balance -= amount;
            }
            return Balance;
        }
        

        // add method to set the balance to anything
        public static void updateBalance(decimal newBalance)
        {
            Balance = newBalance;
        }

    }
}
