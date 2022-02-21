using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    double price = 2.50;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "apple")
                {
                    double price = 1.20;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "orange")
                {
                    double price = 0.85;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "grapefruit")
                {
                    double price = 1.45;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "kiwi")
                {
                    double price = 2.70;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "pineapple")
                {
                    double price = 5.50;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "grapes")
                {
                    double price = 3.85;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    double price = 2.70;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "apple")
                {
                    double price = 1.25;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "orange")
                {
                    double price = 0.90;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "grapefruit")
                {
                    double price = 1.60;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "kiwi")
                {
                    double price = 3.00;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "pineapple")
                {
                    double price = 5.60;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (fruit == "grapes")
                {
                    double price = 4.20;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }


           
        }
    }
}
