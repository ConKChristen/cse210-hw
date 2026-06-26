using System;

//starter code from Brother Godridge
abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    protected void SetName()
    {
        Console.Write("What is the name of the goal: ");
        _name = Console.ReadLine();
    }
    protected void SetDescription()
    {
        Console.Write($"Enter the description for {_name} goal: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.Write($"Enter the points earned for {_name} goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    protected void SetName(string name)
    {
        _name = name;
    }

    protected void SetDescription(string description)
    {
        _description = description;
    }

    protected void SetPoints(int points)
    {
        _numberOfPoints = points;
    }

    protected void SetStatus(bool status)
    {
        _status = status;
    }


    public int GetPoints()
    {
        return _numberOfPoints;
    }

    public bool IsComplete()
    {
        return _status;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }


    // FOrmat and return a string can be used to display the goal.
    public virtual string GetDisplayString()
    {
        // If this goal is complete, place and X in the status location.
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $"[{statusMarker}] Name: {_name}, Description: {_description}, points earned {_numberOfPoints}";
    }

    /*I
    MarkComplete will set the status to true, which means complete and 
    return the number of points for completing goal.
     */
    protected int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public static BaseGoal CreateFromString(string saveString)
{
    string[] parts = saveString.Split('|');
    string type = parts[0];

    if (type == "SimpleGoal")
    {
        SimpleGoal g = new SimpleGoal();
        g.SetName(parts[1]);
        g.SetDescription(parts[2]);
        g.SetPoints(int.Parse(parts[3]));
        g.SetStatus(bool.Parse(parts[4]));
        return g;
    }
    else if (type == "EternalGoal")
    {
        EternalGoal g = new EternalGoal();
        g.SetName(parts[1]);
        g.SetDescription(parts[2]);
        g.SetPoints(int.Parse(parts[3]));
        return g;
    }
    else if (type == "ChecklistGoal")
    {
        ChecklistGoal g = new ChecklistGoal();
        g.SetName(parts[1]);
        g.SetDescription(parts[2]);
        g.SetPoints(int.Parse(parts[3]));
        g.SetCurrentCount(int.Parse(parts[4]));
        g.SetTargetCount(int.Parse(parts[5]));
        g.SetBonusPoints(int.Parse(parts[6]));
        g.SetStatus(bool.Parse(parts[7]));
        return g;
    }

    throw new Exception("Unknown goal type in save file.");
}


    public abstract void CreateGoal();
    public abstract int RecordEvent();
    public abstract string GetSaveString();

}