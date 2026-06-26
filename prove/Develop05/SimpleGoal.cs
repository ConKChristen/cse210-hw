using System;

class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
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
        return MarkComplete();
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}