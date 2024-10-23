using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    internal class Account
    {
        private string _accountholder;
        // this is a backing field to the public one
        private double _amount;
        

        public Account(string accountholder)
        { 
            _accountholder = accountholder;
            _amount = 0;
        }

        public void Deposit(double amount) 
        {
            _amount += amount;
            LogTransaction($"Deposited {amount:F2} into account");

            Console.WriteLine($"Deposit successful.");
        }

        private void LogTransaction(string message) 
        {
            Console.WriteLine($"Transaction: {message}");
        }

        public void DisplayAccountInfo() 
        {
            Console.WriteLine($"Accountholder: {_accountholder}");
            Console.WriteLine($"Balance: {_amount:F2}");
        }
    }
}
