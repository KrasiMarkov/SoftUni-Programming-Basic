using System;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numTicketsForOlder = int.Parse(Console.ReadLine());
            int numTicketsForKids = int.Parse(Console.ReadLine());
            double priceTicketsForOlder = double.Parse(Console.ReadLine());
            double pricePeeTax = double.Parse(Console.ReadLine());


            double priceTicketsForKids = priceTicketsForOlder - priceTicketsForOlder * 0.7;
            double priceTicketsForOlderPeeTax = priceTicketsForOlder + pricePeeTax;
            double priceTicketsForKidspeeTax = priceTicketsForKids + pricePeeTax;
            double totalPrice = (numTicketsForKids * priceTicketsForKidspeeTax) + (numTicketsForOlder * priceTicketsForOlderPeeTax);
            double profit = totalPrice * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:F2} lv.");
        }
    }
}
