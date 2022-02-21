using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int numNight = int.Parse(Console.ReadLine());

            double priceForStudio = 0.0;
            double priceForApartment = 0.0;

            switch (mounth)
            {
                case "May":
                case "October":


                    priceForStudio = 50 * numNight;
                    priceForApartment = 65 * numNight;

                    if (numNight > 7)
                    {
                        priceForStudio = priceForStudio * 0.95;

                    }
                    else if (numNight > 14)
                    {
                        priceForStudio = priceForStudio * 0.7;
                        priceForApartment = priceForApartment * 0.9;
                    }
                    Console.WriteLine($"Apartment: {priceForApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceForStudio:F2} lv.");
                    break;

                case "June":
                case "Septembre":


                    priceForStudio = 75.20 * numNight;
                    priceForApartment = 68.70 * numNight;

                    if (numNight > 14)
                    {
                        priceForStudio = priceForStudio * 0.8;
                        priceForApartment = priceForApartment * 0.9;
                    }
                    Console.WriteLine($"Apartment: {priceForApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceForStudio:F2} lv.");
                    break;
                case "July":
                case "August":


                    priceForStudio = 76 * numNight;
                    priceForApartment = 77 * numNight;
                    if (numNight > 14)
                    {
                        priceForApartment = priceForApartment * 0.9;
                    }
                    Console.WriteLine($"Apartment: {priceForApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceForStudio:F2} lv.");
                    break;

                   
            }       


        }
    }
}
