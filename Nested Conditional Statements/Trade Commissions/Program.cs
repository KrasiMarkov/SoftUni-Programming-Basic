using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    double commission = sales * 0.05;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    double commission = sales * 0.07;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    double commission = sales * 0.08;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 10000)
                {
                    double commission = sales * 0.12;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    double commission = sales * 0.045;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    double commission = sales * 0.075;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    double commission = sales * 0.10;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 10000)
                {
                    double commission = sales * 0.13;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    double commission = sales * 0.055;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    double commission = sales * 0.08;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    double commission = sales * 0.12;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 10000)
                {
                    double commission = sales * 0.145;
                    Console.WriteLine($"{commission:F2}");
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
