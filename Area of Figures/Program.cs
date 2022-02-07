using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string KindFigure = Console.ReadLine();
            if (KindFigure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:F3}");
            }
            else if (KindFigure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double area = b * c;
                Console.WriteLine($"{area:F3}");
            }
            else if (KindFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine($"{area:F3}");
            }
            else if (KindFigure == "triangle")
            {
                double d = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (d * h) / 2;
                Console.WriteLine($"{area:F3}");
            }

        }
    }
}
