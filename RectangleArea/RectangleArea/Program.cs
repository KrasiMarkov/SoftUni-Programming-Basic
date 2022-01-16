using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double length = Math.Abs(X1 - X2);
            double wigth = Math.Abs(Y1 - Y2);
            double area = length * wigth;
            double perimeter = 2 * (length + wigth);
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
