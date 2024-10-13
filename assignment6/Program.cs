namespace assignment6
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
            //Console.Write("Enter accountholder's name: ");
            //string accountholder = Console.ReadLine();
            //Account account = new(accountholder);

            Account account = new("Henry");

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Deposit(amount);
            account.DisplayAccountInfo();
        }
    }
}
