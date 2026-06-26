using System;

class EternalGoal : BaseGoal
{
    public EternalGoal() : base()
    {
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Well done! You have earned {GetPoints()} points!");
        return GetPoints();
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}