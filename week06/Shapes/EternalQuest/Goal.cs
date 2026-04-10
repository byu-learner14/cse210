public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();          // Returns points earned this time (polymorphism)
    public abstract bool IsComplete();
    public abstract string GetDetailsString();  // Shows [X] or [ ] + checklist progress
    public abstract string GetStringRepresentation(); // For saving to file
}