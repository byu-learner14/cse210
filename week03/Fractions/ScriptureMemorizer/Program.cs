// =============================================
// PROGRAM.CS
// =============================================

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Load library and pick a random scripture
        List<Scripture> scriptureLibrary = GetScriptureLibrary();
        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            currentScripture.Display();

            // Final state check — show the completely hidden scripture before ending
            if (currentScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are now hidden. Great job memorizing!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (input == "quit")
            {
                break;
            }

            // Hide 1–5 random visible words
            int wordsToHide = random.Next(1, 6);
            currentScripture.HideRandomWords(wordsToHide);
        }
    }

    private static List<Scripture> GetScriptureLibrary()
    {
        var library = new List<Scripture>();

        // Scripture 1 — single verse
        library.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));

        // Scripture 2 — verse range
        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        // Scripture 3
        library.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all this through him who gives me strength."));

        // Scripture 4
        library.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd, I lack nothing."));

        // Scripture 5 — longer range example
        library.Add(new Scripture(
            new Reference("Matthew", 5, 14, 16),
            "You are the light of the world. A town built on a hill cannot be hidden. Neither do people light a lamp and put it under a bowl. Instead they put it on its stand, and it gives light to everyone in the house. In the same way, let your light shine before others, that they may see your good deeds and glorify your Father in heaven."));

        return library;
    }
}