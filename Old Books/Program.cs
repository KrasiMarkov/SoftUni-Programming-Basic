using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string loveBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            string othersBook = Console.ReadLine();
            int counter = 0;
            while (othersBook != loveBook)
            {
                if (counter < capacity)
                {
                    othersBook = Console.ReadLine();
                    counter++;
                }
                else
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {capacity} books.");
                    break;
                }

            }
            if (othersBook == loveBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
