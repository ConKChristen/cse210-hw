using System;

class ChecklistGoal : BaseGoal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal() : base()
    {
        _currentCount = 0;
    }

    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }

    public void SetTargetCount(int target)
    {
        _targetCount = target;
    }

    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        SetBonusRequirements();
        SetBonusPoints();
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }

        _currentCount++;

        int earned = GetPoints();

        if (_currentCount == _targetCount)
        {
            earned += _bonusPoints;
            MarkComplete();
            Console.WriteLine($"Goal completed! You earned {earned} points including {_bonusPoints} bonus points!");
        }
        else
        {
            Console.WriteLine($"Good job! You earned {GetPoints()} points.");
        }
        return earned;
    }

    public override string GetDisplayString()
    {
        char statusMarker = IsComplete() ? 'X' : ' ';
        return $"[{statusMarker}] {GetName()} ({_currentCount}/{_targetCount})";
    }

    protected void SetBonusRequirements()
    {
        Console.Write($"How many times does this goal have to be accomplished for a bonus: ");
        _targetCount = int.Parse(Console.ReadLine());
    }

    protected void SetBonusPoints()
    {
        Console.Write($"What is the bonus for accomplishing it that many times: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override string GetSaveString()
{
    return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_currentCount}|{_targetCount}|{_bonusPoints}|{IsComplete()}";
}
}