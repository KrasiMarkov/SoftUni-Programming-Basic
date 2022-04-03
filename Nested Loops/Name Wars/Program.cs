using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sum = 0;
            int totalSum = 0;
            string name2 = "";
            while (name != "STOP")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    char symbol = name[i];
                    sum = sum + ((int)symbol);
                }
                if (totalSum < sum)
                {
                    totalSum = sum;
                    name2 = name;

                }
                sum = 0;
                name = Console.ReadLine();

            }
            Console.WriteLine($"Winner is {name2} - {totalSum}!");
        }
    }
}
