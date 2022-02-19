using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double priceForPremiere = 12.00;
            double priceForNormal = 7.50;
            double priceForDiscount = 5.00;

            if (projection == "Premiere")
            {
                double result = priceForPremiere * row * column;
                Console.WriteLine($"{result:F2} leva");
            }
            else if (projection == "Normal")
            {
                double result = priceForNormal * row * column;
                Console.WriteLine($"{result:F2} leva");
            }
            else if (projection == "Discount")
            {
                double result = priceForDiscount * row * column;
                Console.WriteLine($"{result:F2} leva");
            }
        }
    }
}
