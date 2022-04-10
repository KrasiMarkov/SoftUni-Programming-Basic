using System;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMovies = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            string movieMaxRating = "";
            string movieMinRating = "";
            double minRating = double.MaxValue;
            double counter = 0.0;
            for (int i = 1; i <= numMovies; i++)
            {
                string nameMovie = Console.ReadLine();
                double ratingMovie = double.Parse(Console.ReadLine());

                if (ratingMovie > maxRating)
                {
                    maxRating = ratingMovie;
                    movieMaxRating = nameMovie;
                }
                if (ratingMovie < minRating)
                {

                    minRating = ratingMovie;
                    movieMinRating = nameMovie;
                }

                counter = counter + ratingMovie;
            }
            double averageRating = counter / numMovies;
            Console.WriteLine($"{movieMaxRating} is with highest rating: {maxRating:F1}");
            Console.WriteLine($"{movieMinRating} is with lowest rating: {minRating:F1}");
            Console.WriteLine($"Average rating: {averageRating:F1}");
        }
    }
}
