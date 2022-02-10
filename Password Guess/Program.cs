using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password = Console.ReadLine();
            string MyPassword = "s3cr3t!P@ssw0rd";
            if (Password == MyPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
