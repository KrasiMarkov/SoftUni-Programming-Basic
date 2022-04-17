using System;

namespace Airplane_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            double counterForWindowSeatPercent = 0.0;
            double counterForMiddleSeatPercent = 0.0;
            double counterForAisleSeatPercent = 0.0;
            double percent = 100.0 / numPeople;

            for (int i = 1; i <= numPeople; i++)
            {
                string number = Console.ReadLine();
                char symbol = number[1];


                if (symbol == 'A' || symbol == 'F')
                {
                    counterForWindowSeatPercent = counterForWindowSeatPercent + percent;
                }
                else if (symbol == 'B' || symbol == 'E')
                {
                    counterForMiddleSeatPercent = counterForMiddleSeatPercent + percent;
                }
                else if (symbol == 'C' || symbol == 'D')
                {
                    counterForAisleSeatPercent = counterForAisleSeatPercent + percent;
                }

            }
            Console.WriteLine($"Window Seats: {counterForWindowSeatPercent:F2}%");
            Console.WriteLine($"Middle Seats: {counterForMiddleSeatPercent:F2}%");
            Console.WriteLine($"Aisle Seats: {counterForAisleSeatPercent:F2}%");

        }
    }
}
