using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    class BankAccount
    {
        public string AccountNumber {  get; set; }
        public double Balance {  get; set; }


        public BankAccount(string accountNumber, double intialBalance)
        {
            AccountNumber = accountNumber;
            Balance = intialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit successful.");
        }

        public void Withdraw(double amount) 
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal succesful");
        }

    }
}
