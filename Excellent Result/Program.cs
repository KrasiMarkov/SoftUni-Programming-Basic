using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double Number = double.Parse(Console.ReadLine());
            if (Number >= 5.50)
            {
              Console.WriteLine("Excellent!");
            }
        }
    }
}
