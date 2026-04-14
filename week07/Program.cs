using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create at least one of each activity (exactly as the assignment requires)
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),      // Matches sample
            new Cycling(new DateTime(2022, 11, 3), 30, 12.0),     // Nice round numbers
            new Swimming(new DateTime(2022, 11, 3), 30, 20)       // Example lap swim
        };

        // Display summary for every activity in the list (polymorphism in action!)
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}