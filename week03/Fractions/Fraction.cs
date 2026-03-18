public class Fraction
{
    private int _top;      // Numerator
    private int _bottom;   // Denominator

    // Constructor 1: no parameters - 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: whole number - n/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor 3: full fraction n/d
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
        // Optional: you could add check for bottom != 0 here,
    }

    // Returns string like "3/4" or "5/1" or "1/1"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value (double)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}