using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int maxNum = int.MinValue;
            while (counter < n)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNum)
                {
                    maxNum = number;
                }
                counter++;
            }
            Console.WriteLine(maxNum);
        }
    }
}
