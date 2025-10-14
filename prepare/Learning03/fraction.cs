using System;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (top number)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two para
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

        // Getters and Setters
    public int GetT()
    {
        return _top;
    }

    public void SetT(int top)
    {
        _top = top;
    }

    public int GetB()
    {
        return _bottom;
    }

    public void SetB(int bottom)
    {
        _bottom = bottom;
    }

    // Method that returns the fraction as a string, like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method that returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }    
}