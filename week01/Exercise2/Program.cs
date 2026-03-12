using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        
        // Convert string to integer
        int percentage = int.Parse(input);
        
        // Step 3: We'll determine the letter and store it in a variable
        string letter = "";
        
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Step 3 continued: Print the letter grade once, at the end
        Console.WriteLine($"Your grade is: {letter}");
        
        // Requirement 2: Separate check for passing (≥ 70)
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time!");
        }
    }
}