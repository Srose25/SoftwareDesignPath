using System.Reflection.Metadata;

public class Fraction
{
    private int _top;
    private int _bottom;



//Initialize
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }




//These methods return values
    public string GetTop()
    {
        return $"{_top}";
    }

    public string GetBottom()
    {
        return $"{_bottom}";
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double) _top / _bottom;
    }
}