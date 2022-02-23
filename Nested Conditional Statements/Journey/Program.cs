using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;

            if (budjet <= 100)
            {
                if (season == "summer")
                {
                    price = budjet * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {price:F2}");
                }
                else if (season == "winter")
                {
                    price = budjet * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {price:F2}");
                }
            }
            else if (budjet <= 1000)
            {
                if (season == "summer")
                {
                    price = budjet * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {price:F2}");
                }
                else if (season == "winter")
                {
                    price = budjet * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {price:F2}");
                }
            }
            else if (budjet > 1000)
            {
                price = budjet * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {price:F2}");
            }
        }
    }
}
