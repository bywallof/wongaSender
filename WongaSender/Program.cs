using System;

namespace WongaSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Wonga Messaging System.\n\n"
                + "Please enter your name:");

            String name = Console.ReadLine();

            if ((new Messaging(name).Initiate()) == true)
            {
                Console.WriteLine("Your name has been sent to the Wonga Application"
                    + "\nPlease check for any changes on the Wonga Appliction"
                    + "\nThank you so much.");
            }
            else
            {
                Console.WriteLine("For some reason the we failed to forward your name to Wonga Applicaiton");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Wonga Technologies Copyright 2021 - Powered by Riaz Hlatshwayo");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Read();
        }
    }
}
