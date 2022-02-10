using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine(FirstNumber);
            }
            else 
            {
                Console.WriteLine(SecondNumber);
            }


        }
    }
}
