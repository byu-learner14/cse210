using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);   // Step 5: random 1-100
        
        int guess;
        
        // Core requirement 3: loop until the guess is correct
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}