using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private readonly double _balance;
        
        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating as Deposit of the {amount, 0:c} to your account!!");
        }

        public double GetBalance()
        {
            return _balance;
        }
    }

    

    
    
}
