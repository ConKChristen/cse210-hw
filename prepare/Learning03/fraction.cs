using System;

public class Fraction
{
    //Make these attributes private.  The rest of the code can't access this
    private int _numerator;
    private int _denominator;

    // Constructors
    //Constructors are special methods that are called automatically when an object is created. Their purpose is to help set up the initial state of an object. 
    // The name of a constructor must match the class name, and the return type is left empty (not even void). 
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    //Setters: To let code outside the class change a private variable inside the class.

    public void SetTop(int value)
    {
        _numerator = value;
    }

    public void SetBott(int value)
    {
        if (value != 0)
        {
            _denominator = value;
        }
        else
        {
            _denominator = 1;
        }
    }

    //Getters: To let code outside the class read a private variable inside the class.

    public int GetTop()
    {
        return _numerator;
    }
    public int GetBottom()
    {
        return _denominator;
    }

    // Getters and setters enforce encapsulation by controlling how private data is accessed and modified. 
    // Instead of exposing fields directly, they provide a safe interface for validation, transformation, and consistency.

    public string GetFraction()
    {
        return _numerator + "/" + _denominator;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}