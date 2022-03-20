using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps = totalSteps + steps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                input = Console.ReadLine();

            }
            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalSteps = totalSteps + stepsToHome;
                if (10000 <= totalSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                }
            }
            

           
        }
    }
}
