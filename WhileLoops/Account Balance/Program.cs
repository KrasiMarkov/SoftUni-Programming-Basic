using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            int counter = 0;
            double total = 0;
            while (counter < numOfOperations)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                total = total + deposit;
                counter++;
            }
            Console.WriteLine($"Total: {total:F2}");



        }
    }
}
