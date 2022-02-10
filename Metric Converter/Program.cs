using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Number = double.Parse(Console.ReadLine()); // 40
            string Input = Console.ReadLine();                // m
            string Output = Console.ReadLine();               // m

            if (Input == "cm")
            {
                Number = Number / 100;
            }
            else if (Input == "mm")
            {
                Number = Number / 1000;
            }
            if (Output == "cm")
            {
                Console.WriteLine($"{(Number * 100):F3}");
            }
            else if (Output == "mm")
            {
                Console.WriteLine($"{(Number * 1000):F3}");
            }
            else
            {
                Console.WriteLine($"{Number:F3}");
            }

        }
    }
}
