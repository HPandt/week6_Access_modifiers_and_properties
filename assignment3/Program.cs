using System;

namespace assignment3
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
            Console.Write("Enter car make: ");
            string make = Console.ReadLine();

            Console.Write("Enter car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter car year: ");
            int year = int.Parse(Console.ReadLine());

            Car car = new(make, model, year);

            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Model: {car.Year}");
        }
    }
}
