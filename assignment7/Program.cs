namespace assignment7
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
            Console.Write("Enter product name: ");
            string productname = Console.ReadLine();

            Console.Write("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new(productname, price);

            Console.WriteLine("Product Details: ");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
        }
    }
}
