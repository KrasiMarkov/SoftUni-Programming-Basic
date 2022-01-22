using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numTable = double.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double wigthTable = double.Parse(Console.ReadLine());
            double areaP = numTable * (lengthTable + 2 * 0.30) * (wigthTable + 2 * 0.30);
            double areaK = numTable * (lengthTable / 2) * (lengthTable / 2);
            double PriceUsd = areaP * 7 + areaK * 9;
            double PriceBgn = PriceUsd * 1.85;
            Console.WriteLine($"{PriceUsd:F2} USD");
            Console.WriteLine($"{PriceBgn:F2} BGN");
        }
    }
}
