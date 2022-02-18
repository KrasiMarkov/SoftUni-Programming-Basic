using System;

namespace Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hour = int.Parse(Console.ReadLine());
            int Minutes = int.Parse(Console.ReadLine());

            Minutes = Minutes + 15;

            if (Minutes > 59)
            {
                Hour = Hour + 1;
                Minutes = Minutes - 60;
            }
            if (Hour > 23)
            {
                Hour = 0;
            }
            if (Minutes < 10)
            {
                Console.WriteLine($"{Hour}:0{Minutes}");
            }
            else
            { 
                Console.WriteLine($"{Hour}:{Minutes}");
            }
        }      
    }
}
