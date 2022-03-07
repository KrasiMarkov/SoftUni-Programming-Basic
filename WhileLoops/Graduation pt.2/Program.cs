using System;

namespace Graduation_pt._2
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
            int excluded = 0;
            bool isExcluded = false;

            while (counter < n)
            {

                double annualAssessment = double.Parse(Console.ReadLine());
                if (annualAssessment < 4.00)
                {

                    excluded++;
                    if (excluded == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        isExcluded = true;
                        break;
                    }
                    counter++;
                }
                else if (annualAssessment >= 4.00)
                {
                    averageGrade = averageGrade + annualAssessment;
                    counter++;
                }


            }
            if (isExcluded == false)
            {
                totalAverageGrade = averageGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {totalAverageGrade:F2}");
            }
           

        }
    }
}
