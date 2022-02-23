using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFlowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double price = 0;


            switch (kindOfFlowers)
            {
                case "Roses":
                    price = 5 * numFlowers;
                    if (numFlowers > 80)
                    {
                        price = price * 0.9;
                    }
                    break;
                case "Dahlias":
                    price = 3.80 * numFlowers;
                    if (numFlowers > 90)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Tulips":
                    price = 2.80 * numFlowers;
                    if (numFlowers > 80)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Narcissus":
                    price = 3 * numFlowers;
                    if (numFlowers < 120)
                    {
                        price = price + (price * 0.15);
                    }
                    break;
                case "Gladiolus":
                    price = 2.50 * numFlowers;
                    if (numFlowers < 80)
                    {
                        price = price + (price * 0.2);
                    }
                    break;
                default:
                    break;



            }
            if (budjet >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {kindOfFlowers} and {(budjet - price):F2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {(price - budjet):F2} leva more.");                 
            }





        }
    }
}
