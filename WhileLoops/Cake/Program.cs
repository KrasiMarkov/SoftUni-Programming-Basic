using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int weigth = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalPiesec = 1;
            int maxPiesecOfCake = weigth * length;
            while (command != "STOP")
            {

               
                if (totalPiesec >= 0)
                {
                     int numPieces = int.Parse(command);
                     totalPiesec = maxPiesecOfCake - numPieces;
                    
                    numPieces = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (totalPiesec < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {totalPiesec - maxPiesecOfCake} piesec more.");
                        break;
                    }
                    break;
                }
                




            }
            if (command == "STOP")
            {
                Console.WriteLine($"{maxPiesecOfCake - maxPiesecOfCake} piesec are left.");
            }
        }
    }
}
