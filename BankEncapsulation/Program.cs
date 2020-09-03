using System;
using System.Dynamic;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            bool quit = false;
            Console.WriteLine("Welcome to our bank!");

            BankAccount bankAccount = new BankAccount();
           
            do
            {
                Console.WriteLine($"Please enter one of the follow choices. \n" + "Balance \n" + "Deposit \n" + "Withdraw \n" + "Quit");

                string option = (Console.ReadLine().ToLower().Trim());

                if (option == "balance")
                {
                    Console.WriteLine("Your current balance:");
                    bankAccount.GetBalance();
                    Console.WriteLine($"${bankAccount.GetBalance()}");
                }
                else if (option == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    var amount = Convert.ToDouble(Console.ReadLine());

                    bankAccount.Deposit(amount);
                    Console.WriteLine($"Your new balance is ${bankAccount.GetBalance()}");
                }
                else if (option == "withdraw")
                {

                    Console.WriteLine("How much would you like to withdraw?");
                    var amount = Convert.ToDouble(Console.ReadLine());
                    bankAccount.Withdraw(amount);
                    Console.WriteLine($"Your new balance is ${bankAccount.GetBalance()}");
                }
                else  if (option == "quit")
                {
                    quit = true;
                    Console.WriteLine("Thank you for your patronage. \n" + "Goodbye");
                }
            } while (quit == false);
        }
    }  

}
