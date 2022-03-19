using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            
            
            int spendingCounter = 0;
            int counterForDays = 0;
            while (moneyOnHand < needMoney && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                counterForDays++;
                if (action == "spend")
                {

                    moneyOnHand = moneyOnHand - sum;
                    spendingCounter++;
                    if (moneyOnHand < 0)
                    {
                        moneyOnHand = 0;
                    }
                }
                else if (action == "save")
                {
                    moneyOnHand = moneyOnHand + sum;
                    spendingCounter = 0;
                }

            }
            if (spendingCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(counterForDays);
            }
            if (moneyOnHand >= needMoney)
            {
                Console.WriteLine($"You saved the money for {counterForDays} days.");
            }

        }
    }
}

    