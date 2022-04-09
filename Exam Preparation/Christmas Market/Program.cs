using System;

namespace Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numFantasyBooks = int.Parse(Console.ReadLine());
            int numHororBooks = int.Parse(Console.ReadLine());
            int numRomanticsBooks = int.Parse(Console.ReadLine());

            double priceFantasy = 14.90;
            double priceHoror = 9.80;
            double priceRomantics = 4.30;
            double totalmoney = numFantasyBooks * priceFantasy + numHororBooks * priceHoror + numRomanticsBooks * priceRomantics;

            totalmoney = totalmoney - totalmoney * 0.2;


            if (totalmoney >= money)
            {

                double profit = totalmoney - money;
                totalmoney = totalmoney - profit;
                double profitForSellers = Math.Floor(profit * 0.1);
                profit = profit - profitForSellers;
                totalmoney = totalmoney + profit;
                Console.WriteLine($"{totalmoney:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {profitForSellers} leva.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(money - totalmoney):F2} money needed.");
            }


        }
    }
}
