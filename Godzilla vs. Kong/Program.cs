using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double BudgetFilm = double.Parse(Console.ReadLine());
            int NumStatist = int.Parse(Console.ReadLine());
            double PriceForStatist = double.Parse(Console.ReadLine());

            double SumForDecor = BudgetFilm * 0.1;
            double SumForClothing = NumStatist * PriceForStatist;
           
            if (NumStatist > 150)
            {
                SumForClothing = SumForClothing - (SumForClothing * 0.1);
            }
            double SumForFilm = SumForDecor + SumForClothing;
            if (SumForFilm > BudgetFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(BudgetFilm - SumForFilm):F2} leva more.");
            }
            else if (SumForFilm <= BudgetFilm)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(BudgetFilm - SumForFilm):F2} leva left.");
            }
        }
    }
}
