using System;

public abstract class Activity
{
    private readonly DateTime _date;
    private readonly int _length; // In minutes

    protected Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate() => _date.ToString("dd MMM yyyy");
    public int GetLength() => _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetLength()} min)- " +
               $"Distance {GetDistance():F1} miles, " +
               $"Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}