using System;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int length)
    {
        _date = date;
        _lengthMinutes = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLength()
    {
        return _lengthMinutes;
    }

    public abstract string GetSummary();

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}