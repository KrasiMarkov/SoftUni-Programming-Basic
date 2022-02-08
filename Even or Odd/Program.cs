using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            if(Number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


        }
    }
}
