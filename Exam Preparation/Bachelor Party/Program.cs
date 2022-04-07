using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sumMoney = 0;
            int sumPeople = 0;
            while (command != "The restaurant is full")
            {
                int numPeople = int.Parse(command);
                sumPeople = sumPeople + numPeople;

                if (numPeople < 5)
                {
                    sumMoney = sumMoney + numPeople * 100;
                }
                else
                {
                    sumMoney = sumMoney + numPeople * 70;
                }

                command = Console.ReadLine();
            }
            if (sumMoney >= guest)
            {
                Console.WriteLine($"You have {sumPeople} guests and {sumMoney - guest} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {sumPeople} guests and {sumMoney} leva income, but no singer.");
            }

        }
    }
}
