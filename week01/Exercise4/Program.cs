using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;   // exit early — clean
        }

        // Core: sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Core: average
        double average = (double)sum / numbers.Count;

        // Core: max (can combine with sum loop, but keeping separate is fine)
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Stretch 1: smallest positive
        int? smallestPositive = null;
        foreach (int num in numbers)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive.Value))
            {
                smallestPositive = num;
            }
        }

        // Output — core first, then stretch
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        // Stretch 2: sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}