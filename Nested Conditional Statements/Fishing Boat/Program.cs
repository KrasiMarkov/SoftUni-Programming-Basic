using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFisherman = int.Parse(Console.ReadLine());

            double result = 0;

            switch (season)
            {
                case "Spring":
                    if (numFisherman <= 6)
                    {

                        result = 3000 * 0.9;

                    }
                    else if (numFisherman >= 7 && numFisherman <= 11)
                    {

                        result = 3000 * 0.85;

                    }
                    else if (numFisherman >= 12)
                    {


                        result = 3000 * 0.75;

                    }
                    break;

                case "Summer":
                    if (numFisherman <= 6)
                    {


                        result = 4200 * 0.9;

                    }
                    else if (numFisherman >= 7 && numFisherman <= 11)
                    {

                        result = 4200 * 0.85;

                    }
                    else if (numFisherman >= 12)
                    {

                        result = 4200 * 0.75;

                    }
                    break;
                case "Autumn":
                    if (numFisherman <= 6)
                    {
                        result = 4200 * 0.9;
                    }
                    else if (numFisherman >= 7 && numFisherman <= 11)
                    {
                        result = 4200 * 0.85;
                    }
                    else if (numFisherman >= 12)
                    {
                        result = 4200 * 0.75;
                    }
                    break;
                case "Winter":
                    if (numFisherman <= 6)
                    {

                        result = 2600 * 0.9;

                    }
                    else if (numFisherman >= 7 && numFisherman <= 11)
                    {

                        result = 2600 * 0.85;

                    }
                    else if (numFisherman >= 12)
                    {
                        result = 2600 * 0.75;

                    }
                    break;
                default:
                    break;

            }
            if (numFisherman % 2 == 0 && season != "Autumn")
            {
                result = result * 0.95;
            }
            if (budjet >= result)
            {
                Console.WriteLine($"Yes! You have {(budjet - result):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(result - budjet):F2} leva.");
            }






        }
    }
}
