using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int Days = int.Parse(Console.ReadLine());
            int Confectioners = int.Parse(Console.ReadLine());
            int Cake = int.Parse(Console.ReadLine());
            int Corrugations = int.Parse(Console.ReadLine());
            int Pancake = int.Parse(Console.ReadLine());

            //Logic
            double SumCakeForDay = Cake * 45;
            double SumCorrugationsForDay = Corrugations * 5.80;
            double SumPancakeForDay = Pancake * 3.20;

            double SumForDay = (SumCakeForDay + SumCorrugationsForDay + SumPancakeForDay) * Confectioners;
            double SumForAllCampaign = SumForDay * Days;
            double SumAfterExpense = SumForAllCampaign * 1 / 8;
            double EndSum = SumForAllCampaign - SumAfterExpense;

            //Output
            Console.WriteLine($"{EndSum:F2}");
        }
    }
}
