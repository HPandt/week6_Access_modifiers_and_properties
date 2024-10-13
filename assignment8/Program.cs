using System.Security.Principal;

namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            //Console.Write("Enter Account Number name: ");
            //string accountNumber = Console.ReadLine();
            //Console.Write("Enter Account Balance: ");
            //double balance = double.Parse(Console.ReadLine());
            //BankAccount bankAccount = new(accountNumber, balance);

            BankAccount bankAccount = new("123456", 2300);

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());
            bankAccount.Deposit(amount);

            Console.Write("Enter withdrawal amount: ");
            double amount2 = double.Parse(Console.ReadLine());
            bankAccount.Withdraw(amount2);

            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {bankAccount.AccountNumber}");
            Console.WriteLine($"Balance: {bankAccount.Balance}");

            
        }
    }
}
