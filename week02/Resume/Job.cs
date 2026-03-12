using System;

/// <summary>
/// Represents a single job experience with company, title, and years.
/// </summary>
public class Job
{
    // Member variables (attributes) - convention is _underscoreCamelCase
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Method to display job details in the required format
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}