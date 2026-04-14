public class Cycling : Activity
{
    private readonly double _speed; // mph

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * (GetLength() / 60.0);

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60.0 / GetSpeed();
}