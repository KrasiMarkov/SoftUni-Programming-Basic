using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            int n = 12;
            double averageGrade = 0;
            double totalAverageGrade = 0;
            while (counter < n)
            {

                double annualAssessment = double.Parse(Console.ReadLine());
                if (annualAssessment < 4.00)
                {
                    
                    continue;
                }
                averageGrade = averageGrade + annualAssessment;
                counter++;

            }
            totalAverageGrade = averageGrade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {totalAverageGrade:F2}");
        }
    }
}
