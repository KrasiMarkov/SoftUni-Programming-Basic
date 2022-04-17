using System;

namespace Book_a_Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            double lenghtOfFlight = double.Parse(Console.ReadLine());
            int numPeople = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            switch (ticket)
            {
                case "Economy":
                    if (numPeople <= 6)
                    {
                        if (lenghtOfFlight < 1500)
                        {
                            totalPrice = numPeople * 59.99;
                        }
                        else if (lenghtOfFlight <= 3500)
                        {
                            totalPrice = numPeople * 184.99;
                        }
                        else if (lenghtOfFlight > 3500)
                        {
                            totalPrice = numPeople * 269.99;
                        }
                    }
                    else
                    {
                        if (lenghtOfFlight < 1500)
                        {
                            totalPrice = numPeople * 59.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                        else if (lenghtOfFlight <= 3500)
                        {
                            totalPrice = numPeople * 184.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                        else if (lenghtOfFlight > 3500)
                        {
                            totalPrice = numPeople * 269.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                    }
                    break;
                case "Premium":
                    if (numPeople <= 6)
                    {
                        if (lenghtOfFlight < 1500)
                        {
                            totalPrice = numPeople * 179.99;
                        }
                        else if (lenghtOfFlight <= 3500)
                        {
                            totalPrice = numPeople * 279.99;
                        }
                        else if (lenghtOfFlight > 3500)
                        {
                            totalPrice = numPeople * 394.99;
                        }
                    }
                    else
                    {
                        if (lenghtOfFlight < 1500)
                        {
                            totalPrice = numPeople * 179.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                        else if (lenghtOfFlight <= 3500)
                        {
                            totalPrice = numPeople * 279.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                        else if (lenghtOfFlight > 3500)
                        {
                            totalPrice = numPeople * 394.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                    }


                    break;
                case "Business":
                    if (numPeople <= 6)
                    {
                        if (lenghtOfFlight < 1500)
                        {
                            totalPrice = numPeople * 254.99;
                        }
                        else if (lenghtOfFlight <= 3500)
                        {
                            totalPrice = numPeople * 379.99;
                        }
                        else if (lenghtOfFlight > 3500)
                        {
                            totalPrice = numPeople * 619.99;
                        }
                    }
                    else
                    {
                        if (lenghtOfFlight < 1500)
                        {
                            totalPrice = numPeople * 254.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                        else if (lenghtOfFlight <= 3500)
                        {
                            totalPrice = numPeople * 379.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                        else if (lenghtOfFlight > 3500)
                        {
                            totalPrice = numPeople * 619.99;
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                    }

                    break;


            }
            Console.WriteLine($"The total price of the tickets is: {totalPrice:F2} lv.");
        }
    }
}
