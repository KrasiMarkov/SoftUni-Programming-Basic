using System;

namespace Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double Record = double.Parse(Console.ReadLine());
            double Distance = double.Parse(Console.ReadLine());
            double Time = double.Parse(Console.ReadLine());

            double TimeForDistance = Distance * Time;
            double Delay = Math.Floor(Distance / 15);
            double TimeDelay = Delay * 12.5;
            double TotalTime = TimeForDistance + TimeDelay;

            if (Record <= TotalTime)
            {
                Console.WriteLine($"No, he failed! He was {(TotalTime - Record):F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {TotalTime:F2} seconds.");
            }

        }
    }
}
