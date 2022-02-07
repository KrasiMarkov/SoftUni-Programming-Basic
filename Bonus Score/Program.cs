using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartNumPoints = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (StartNumPoints <= 100)
            {
                bonus = 5;
            }
            else if (StartNumPoints > 1000)
            {
                bonus = StartNumPoints * 0.1;
            }
            else
            {
                bonus = StartNumPoints * 0.2;
            }
            if (StartNumPoints % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (StartNumPoints % 10 == 5)
            {
                bonus = bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(StartNumPoints);

        }
    }
}
