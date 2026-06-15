using System;

public class ReflectionActivity : Activity
{
    private string _prompt;
    private string[] _questions;

    public ReflectionActivity()
        : base("Reflection", 
               "This activity will help you reflect on times in your life when you have shown strength, resilience, or personal growth.")
    {
        _prompt = "Think of a time when you overcame a challenge or accomplished something meaningful.";
        
        _questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you feel during this experience?",
            "How can you apply what you learned to future challenges?"
        };
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();

        RunCountDown("Take a moment to think", 5);
        Console.WriteLine();

        int duration = GetDuration();
        int elapsed = 0;
        int questionIndex = 0;

        while (elapsed < duration)
        {
            Console.WriteLine(_questions[questionIndex]);
            RunCountDown("Reflect", 8);
            Console.WriteLine();

            elapsed += 8;
            questionIndex = (questionIndex + 1) % _questions.Length;
        }

        Console.WriteLine("Great job reflecting on your experience.");
        Console.WriteLine();
    }
}