using System;

namespace Christmas_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            bool flag = false;
            while (name != "Stop")
            {

                int sumText = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char symbol = name[i];
                    sumText = sumText + symbol;
                }
                if (sumText <= budjet)
                {
                    Console.WriteLine("Item successfully purchased!");

                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    flag = true;
                    break;
                }
                budjet = budjet - sumText;

                if (flag == true)
                {
                    break;
                }

                name = Console.ReadLine();
            }
            if (name == "Stop")
            {
                Console.WriteLine($"Money left: {budjet}");
            }
        }
    }
}
