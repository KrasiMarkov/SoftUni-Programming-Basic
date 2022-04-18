using System;

namespace Load_Suitcases
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            bool flag = false;
            while (command != "End")
            {


                double volumeSuitcase = double.Parse(command);
                if (volumeSuitcase > trunkCapacity)
                {
                    flag = true;
                    break;
                    
                }
                counter++;
                if (counter == 3)
                {
                    volumeSuitcase = volumeSuitcase + volumeSuitcase * 0.1;
                }


                trunkCapacity = trunkCapacity - volumeSuitcase;


                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else if (flag == true)
            {
                Console.WriteLine("No more space!");

            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");

        }
    }
}
