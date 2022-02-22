using System;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number != 0) && (number <= 99) || (number >= 201))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
