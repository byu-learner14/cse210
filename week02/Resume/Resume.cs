using System;
using System.Collections.Generic;

/// <summary>
/// Represents a person's resume, including name and a list of job experiences.
/// </summary>
public class Resume
{
    // Member variables
    public string _name = "";
    
    // List of Job objects - initialize right away (common and safe pattern)
    public List<Job> _jobs = new List<Job>();

    // Method to display the full resume
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}