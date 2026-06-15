using System;

public class BreathingActivity : Activity
{
    private int _breathInTime;
    private int _breathOutTime;

    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow, deep breathing.")
    {
        _breathInTime = 4;
        _breathOutTime = 6;
    }

    public void Run()
    {
        StartActivity();

        int duration = GetDuration();
        int elapsed = 0;

        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);

        while (elapsed < duration)
        {
            RunCountDown("Breathe in", _breathInTime);
            RunCountDown("Breathe out", _breathOutTime);

            elapsed += _breathInTime + _breathOutTime;
            Console.WriteLine();
        }

        Console.WriteLine("Great job staying focused on your breathing.");
        Console.WriteLine();
    }
}
