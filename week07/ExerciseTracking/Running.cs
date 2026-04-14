using System;

public class Running : Activity
{
    private readonly double _distance; // Miles

    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / GetLength()) * 60;

    public override double GetPace() => GetLength() / GetDistance();
}