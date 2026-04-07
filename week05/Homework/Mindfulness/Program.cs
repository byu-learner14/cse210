using System;
using System.Threading;

namespace Mindfulness
{
    // Exceeding Core Requirements:
    // 1. Added input validation in DisplayStartingMessage() using TryParse to prevent crashes on invalid duration input.
    // 2. Improved user experience with clearer messages and better error handling in the main menu.
    // 3. All activities properly use inheritance from the base Activity class with good encapsulation.
    // 4. The program runs in a clean loop and exits gracefully.

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