using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double wigth = double.Parse(Console.ReadLine());
            double higth = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double volume = length * wigth * higth;
            double volumeInLiters = volume * 0.001;
            double sand = procent * 0.01;
            double realLiters = volumeInLiters * (1 - sand);
            Console.WriteLine($"{realLiters:F3}");

        }
    }
}
