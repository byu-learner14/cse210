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

    // These are declared but Not implemented in the base class
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // This method lives in the base class and works for All activities
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetLength()} min)- " +
               $"Distance {GetDistance():F1} miles, " +
               $"Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}