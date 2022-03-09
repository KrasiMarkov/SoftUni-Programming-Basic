using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int minNum = int.MaxValue;
            while (counter < n)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNum)
                {
                    minNum = number;
                }
                counter++;

            }
            Console.WriteLine(minNum);
        }
    }
}
