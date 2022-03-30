using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();
           
            int totalTicket = 0;
            int ticketsForMovie = 0;
            double busyOfHall = 0.0;
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            double totalStudentTicket = 0.0;
            double totalStandardTicket = 0.0;
            double totalKidTicket = 0.0;
           
            while (nameMovie != "Finish")
            {

                int freeSpace = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                while (ticket != "End")
                {
                    ticketsForMovie++;
                    totalTicket++;
                    
                    if (ticket == "student")
                    {
                        studentTicket++;
                    }
                    else if (ticket == "standard")
                    {
                        standardTicket++;
                    }
                    else if (ticket == "kid")
                    {
                        kidTicket++;
                    }
                    if(ticketsForMovie == freeSpace)
                    {
                        break;
                    }
                   
                    ticket = Console.ReadLine();
                }
                busyOfHall = (ticketsForMovie * 100) * 1.0  / freeSpace * 1.0;
                Console.WriteLine($"{nameMovie} - {busyOfHall:F2}% full.");
                ticketsForMovie = 0;
               
                nameMovie = Console.ReadLine();

            }
            Console.WriteLine($"Total tickets: {totalTicket}");
            totalStudentTicket = (studentTicket * 100) * 1.0 / totalTicket * 1.0;
            totalStandardTicket = (standardTicket * 100) * 1.0 / totalTicket * 1.0;
            totalKidTicket = (kidTicket * 100) * 1.0 / totalTicket * 1.0;
            Console.WriteLine($"{totalStudentTicket:F2}% student tickets.");
            Console.WriteLine($"{totalStandardTicket:F2}% standard tickets.");
            Console.WriteLine($"{totalKidTicket:F2}% kids tickets.");
        }
    }
}
