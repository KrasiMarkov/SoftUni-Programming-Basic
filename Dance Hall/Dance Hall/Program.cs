using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double areaHall = (L * 100) * (W * 100);
            double areaSquare = (A * 100) * (A * 100);
            double bench = areaHall / 10;
            double freeSpace = areaHall - areaSquare - bench;
            double numDancer = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(numDancer));
        }
    }
}
