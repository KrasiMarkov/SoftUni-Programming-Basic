using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceTrip = double.Parse(Console.ReadLine());
            int NumPuzzels = int.Parse(Console.ReadLine());
            int NumDolls = int.Parse(Console.ReadLine());
            int NumTeddyBears = int.Parse(Console.ReadLine());
            int NumMinions = int.Parse(Console.ReadLine());
            int NumTrucks = int.Parse(Console.ReadLine());

            double TotalPrice = (NumPuzzels * 2.60) + (NumDolls * 3) + (NumTeddyBears * 4.10) +( NumMinions * 8.20) + (NumTrucks * 2);
            int ToysCount = NumPuzzels + NumDolls + NumTeddyBears + NumMinions + NumTrucks;


            if (ToysCount >= 50)
            {
                TotalPrice *= 0.75;
            }

            TotalPrice *= 0.90;

            if (TotalPrice >= PriceTrip)
            {
                double MoneyLeft = TotalPrice - PriceTrip;
                Console.WriteLine($"Yes! {MoneyLeft:F2} lv left.");
            }
            else
            {
                double MoneyNeeded = PriceTrip - TotalPrice;
                Console.WriteLine($"Not enough money! {MoneyNeeded:F2} lv needed.");
            }
        }
    }
}
