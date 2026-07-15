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

    public abstract string GetSummery();

    public abstract int GetDistance();

    public abstract int GetSpeed();

    public abstract int GetPace();
}