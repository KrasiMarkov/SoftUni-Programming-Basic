using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            if (timeOfDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    string Outfit = "Sweatshirt";
                    string Shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    string Outfit = "Shirt";
                    string Shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
                else if (degrees >= 25)
                {
                    string Outfit = "T-Shirt";
                    string Shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    string Outfit = "Shirt";
                    string Shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    string Outfit = "T-Shirt";
                    string Shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
                else if (degrees >= 25)
                {
                    string Outfit = "Swim Suit";
                    string Shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }

            }
            else if (timeOfDay == "Evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    string Outfit = "Shirt";
                    string Shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    string Outfit = "Shirt";
                    string Shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
                else if (degrees >= 25)
                {
                    string Outfit = "Shirt";
                    string Shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
                }
            }


        }
    }
}
