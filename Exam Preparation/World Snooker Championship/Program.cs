using System;

namespace World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeChampionship = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());
            double sum = 0.0;
            bool flag = false;
            switch (typeChampionship)
            {
                case "Quarter final":
                    switch (typeTicket)
                    {
                        case "Standard":
                            sum = numTickets * 55.50;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                        case "Premium":
                            sum = numTickets * 105.20;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                        case "VIP":
                            sum = numTickets * 118.90;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;


                    }

                    break;
                case "Semi final":
                    switch (typeTicket)
                    {
                        case "Standard":
                            sum = numTickets * 75.88;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                        case "Premium":
                            sum = numTickets * 125.22;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                        case "VIP":
                            sum = numTickets * 300.40;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                    }

                    break;
                case "Final":
                    switch (typeTicket)
                    {
                        case "Standard":
                            sum = numTickets * 110.10;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                        case "Premium":
                            sum = numTickets * 160.66;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                        case "VIP":
                            sum = numTickets * 400.00;

                            if (sum > 4000)
                            {
                                sum = sum - sum * 0.25;
                                flag = true;

                            }
                            else if (sum > 2500)
                            {
                                sum = sum - sum * 0.1;
                            }
                            if (picture == 'Y')
                            {
                                sum = sum + 40.00 * numTickets;
                                if (flag == true)
                                {
                                    sum = sum - 40.00 * numTickets;
                                }
                            }
                            break;
                    }
                    break;


            }
            Console.WriteLine($"{sum:F2}");


        }
    }
}
