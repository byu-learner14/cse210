using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("====================");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;

                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.Run();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Thank you for taking time to be mindful today!");
                        Console.WriteLine("See you next time! 👋");
                        return; // Exit the program

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}