using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double PriceWiskey = double.Parse(Console.ReadLine());
            double QuantityBeer = double.Parse(Console.ReadLine());
            double QuantityWine = double.Parse(Console.ReadLine());
            double QuantityRakia = double.Parse(Console.ReadLine());
            double QuantityWiskey = double.Parse(Console.ReadLine());

            //Logic
            double PriceRakia = PriceWiskey / 2;
            double PriceWine = PriceRakia - (0.4 * PriceRakia);
            double PriceBeer = PriceRakia - (0.8 * PriceRakia);

            double SumRakia = QuantityRakia * PriceRakia;
            double SumWine = QuantityWine * PriceWine;
            double SumBeer = QuantityBeer * PriceBeer;
            double SumWiskey = QuantityWiskey * PriceWiskey;

            double EndSum = SumRakia + SumWine + SumBeer + SumWiskey;

            //Output
            Console.WriteLine($"{EndSum:F2}");
        }
    }
}
