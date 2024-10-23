namespace primenuber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        void Start()
        {
            int number;

            // Keep asking for input until the user enters 0
            do
            {
                Console.Write("Enter a positive integer (or 0 to exit): ");
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    int primeFactorsCount = CountPrimeFactors(number);
                    Console.WriteLine($"The number of prime factors is: {primeFactorsCount}");
                }

            } while (number != 0);

            Console.WriteLine("Program exited.");
        }

        int CountPrimeFactors(int number)
        {
            int divisor = 2;
            int primeCounter = 0;

            // Continue until number is reduced to 1
            while (number > 1)
            {
                // Check if number is divisible by current divisor
                if (number % divisor == 0)
                {
                    primeCounter++; // Increment prime counter
                    number /= divisor; // Divide the number by divisor
                }
                else
                {
                    divisor++; // next divisor
                }
            }

            return primeCounter;
        }
    }
}
