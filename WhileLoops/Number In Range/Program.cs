using System;

namespace Number_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
