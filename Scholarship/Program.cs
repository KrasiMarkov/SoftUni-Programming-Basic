using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double SizeSocialScholarship = minSalary * 0.35;
            double SizeExsellentScholarship = averageSuccess * 25;

            if (income > minSalary)
            {
                if (averageSuccess < 5.50)
                {
                    Console.WriteLine($"You cannot get a scholarship!");
                }
                else if (averageSuccess >= 5.50)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(SizeExsellentScholarship)} BGN");
                }

            }
            else if (income <= minSalary)
            {
                if (averageSuccess < 4.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (averageSuccess >= 5.50)
                {
                    if (SizeSocialScholarship > SizeExsellentScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(SizeSocialScholarship)} BGN");
                    }
                    else if (SizeSocialScholarship <= SizeExsellentScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(SizeExsellentScholarship)} BGN");
                    }
                }
                else if (averageSuccess >= 4.50)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(SizeSocialScholarship)} BGN");
                }

            }

        }
    }
}
