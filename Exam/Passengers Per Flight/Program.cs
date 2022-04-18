using System;

namespace Passengers_Per_Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAviocompany = int.Parse(Console.ReadLine());
            string newName = "";
            int mostPassengers = 0;

            for (int i = 1; i <= numAviocompany; i++)
            {
                int sumPassengers = 0;
                int counter = 0;
                string nameAviocompany = Console.ReadLine();
                string People = Console.ReadLine();
                while (People != "Finish")
                {
                    int numPassengers = int.Parse(People);
                    sumPassengers = sumPassengers + numPassengers;
                    counter++;

                    People = Console.ReadLine();
                }
                int averageNumPassengers = sumPassengers / counter;
                if (averageNumPassengers > mostPassengers)
                {
                    mostPassengers = averageNumPassengers;
                    nameAviocompany = newName;
                }
                Console.WriteLine($"{nameAviocompany}: {averageNumPassengers} passengers.");
            }
            Console.WriteLine($"{newName} has most passengers per flight: {mostPassengers}");

        }
    }
}
