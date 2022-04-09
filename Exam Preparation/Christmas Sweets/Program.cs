using System;

namespace Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklavaPerKg = double.Parse(Console.ReadLine());
            double priceMuffinsPerKg = double.Parse(Console.ReadLine());
            double stollenKg = double.Parse(Console.ReadLine());
            double candyKg = double.Parse(Console.ReadLine());
            int biscuitsKg = int.Parse(Console.ReadLine());


            double priceStollenPerKg = priceBaklavaPerKg + priceBaklavaPerKg * 0.6;
            double priceCandyPerKg = priceMuffinsPerKg + priceMuffinsPerKg * 0.8;
            double priceBiscuitsPerKg = 7.50;

            double totalPrice = priceStollenPerKg * stollenKg + priceCandyPerKg * candyKg + priceBiscuitsPerKg * biscuitsKg;


            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
