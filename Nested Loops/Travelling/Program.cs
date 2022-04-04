using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            double savedMoney = 0.0;
            while (command != "End")
            {
                double minBudjet = double.Parse(Console.ReadLine());
                double sumMoney = double.Parse(Console.ReadLine());
                savedMoney = savedMoney + sumMoney;
                while (savedMoney < minBudjet)
                {

                    sumMoney = double.Parse(Console.ReadLine());
                    savedMoney = savedMoney + sumMoney;

                }
                Console.WriteLine($"Going to {command}!");
                savedMoney = 0.0;
                minBudjet = 0.0;
                command = Console.ReadLine();
               
                
            }
            
        }
    }
}
