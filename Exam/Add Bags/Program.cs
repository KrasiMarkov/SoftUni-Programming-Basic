using System;

namespace Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBagsOver20kg = double.Parse(Console.ReadLine());
            double KgBags = double.Parse(Console.ReadLine());
            int daysToTravelling = int.Parse(Console.ReadLine());
            int numBags = int.Parse(Console.ReadLine());
            double Tax = 0.0;
            if (KgBags < 10)
            {
                Tax = priceBagsOver20kg * 0.2;
            }
            else if (KgBags <= 20)
            {
                Tax = priceBagsOver20kg * 0.5;
            }
            else if (KgBags > 20)
            {
                Tax = priceBagsOver20kg;
            }
            double totalPriceForBags = numBags * Tax;
            if (daysToTravelling > 30)
            {
                totalPriceForBags = totalPriceForBags + totalPriceForBags * 0.1;
            }
            else if (daysToTravelling >= 7)
            {
                totalPriceForBags = totalPriceForBags + totalPriceForBags * 0.15;
            }
            else if (daysToTravelling < 7)
            {
                totalPriceForBags = totalPriceForBags + totalPriceForBags * 0.4;
            }
            Console.WriteLine($"The total price of bags is: {totalPriceForBags:F2} lv.");





        }
    }
}
