using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceForToy = int.Parse(Console.ReadLine());
            double totalMoneyFromBirthday = 0;
            double sumToys = 0;
            double moneyOfToys = 0;
            int moneyGift = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoneyFromBirthday = totalMoneyFromBirthday + moneyGift;
                    moneyGift = moneyGift + 10;
                    totalMoneyFromBirthday--;
                }
                else
                {
                    sumToys++;
                }
            }
            moneyOfToys = sumToys * priceForToy;
            totalMoneyFromBirthday = totalMoneyFromBirthday + moneyOfToys;
            if (totalMoneyFromBirthday >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(totalMoneyFromBirthday - priceWashingMachine):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWashingMachine - totalMoneyFromBirthday):F2}");
            }
        }
    }
}
