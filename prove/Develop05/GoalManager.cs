using System;
using System.IO; 

class GoalManager
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _score = 0;

    public void AddGoal()
    {
        Console.WriteLine("Chose one of the following goal types to create");
        Console.WriteLine("1.) Simple Goal");
        Console.WriteLine("2.) Eternal Goal");
        Console.WriteLine("3.) Checklist Goal");
        Console.Write("Please enter the number you want to do: ");

        int goalInput = int.Parse(Console.ReadLine());
        BaseGoal newGoal = null;

        if (goalInput == 1)
        {
            newGoal = new SimpleGoal();
        }
        else if (goalInput == 2)
        {
            newGoal = new EternalGoal();
        }
        else if (goalInput == 3)
        {
            newGoal = new ChecklistGoal();
        }
        else
        {
            Console.WriteLine("Pick between 1 and 3");
            return;
        }

        newGoal.CreateGoal();
        _goals.Add(newGoal);

        Console.WriteLine("Goal created successfully!");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        int index = 1;

        foreach (BaseGoal goal in _goals)
        {
            Console.WriteLine($"{index}: {goal.GetDisplayString()}");
            index++;
        }

        Console.WriteLine($"Current Score: {_score}");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        DisplayGoals();
        Console.Write("Enter the goal number: ");

        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        BaseGoal goal = _goals[index];

        int points = goal.RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points. Total score: {_score}");
    }

    public int GetScore()
    {
        return _score;
    }

    public void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Save score first
            outputFile.WriteLine(_score);

            // Save each goal
            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void LoadGoal(string loadfile)
    {
        string[] lines = File.ReadAllLines(loadfile);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            BaseGoal goal = BaseGoal.CreateFromString(lines[i]);
            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}