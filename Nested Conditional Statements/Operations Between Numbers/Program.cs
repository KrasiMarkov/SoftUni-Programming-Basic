using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operater = Console.ReadLine();

            double result = 0;




            if (operater == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operater} {N2} = {result} - even");
                }
                else 
                {
                    Console.WriteLine($"{N1} {operater} {N2} = {result} - odd");
                }

            }
            else if (operater == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operater} {N2} = {result} - even");
                }
                else 
                {
                    Console.WriteLine($"{N1} {operater} {N2} = {result} - odd");
                }
            }
            else if (operater == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operater} {N2} = {result} - even");
                }
                else 
                {
                    Console.WriteLine($"{N1} {operater} {N2} = {result} - odd");
                }
            }
            else if (operater == "/" && N2 != 0)
            {
                result = (double)N1 / N2;
                Console.WriteLine($"{N1} {operater} {N2} = {result:F2}");
            }
            else if (operater == "/" && N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (operater == "%" && N2 != 0)
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} {operater} {N2} = {result}");
            }
            else if (operater == "%" && N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            


                
                
            

        }
    }
}
