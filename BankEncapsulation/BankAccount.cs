using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        private double balance;

        public BankAccount(double currentBalance = 0)
        {
            balance = currentBalance;

        }
        public void Deposit(double currentBalance)
        {
 
            balance += currentBalance;
        }

        public void Withdraw(double currentBalance)
        {
            balance -= currentBalance;
           
        }
        public double GetBalance()
        {
            return balance;
        }
    }

}

