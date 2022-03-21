using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;
            int sumWithoutMaxNum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            sumWithoutMaxNum = sum - maxNum;
            if (maxNum == sumWithoutMaxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNum}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMaxNum - maxNum)}");
            }
            
        }
    }
}
