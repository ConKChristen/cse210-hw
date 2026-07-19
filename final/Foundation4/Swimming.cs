using System;

public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(int laps, string date, int length) :base(date, length)
    {
        _lapCount = laps;
    }

    public override double GetDistance()
    {
        double km = _lapCount * 50 / 1000.0;
        double miles = km * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace {GetPace():0.0} min per mile";
    }
}