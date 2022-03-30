using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFloor = int.Parse(Console.ReadLine());
            int numRoom = int.Parse(Console.ReadLine());

            for (int i = numFloor; i >= 1; i--)
            {
                for (int j = 0; j < numRoom; j++)
                {
                    if (numFloor == i)
                    {
                        Console.Write($"L{i}{j} ");
                    }



                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");
                    }

                }
                Console.WriteLine();
            }
            
        }
    }
}
