using System;

public class ListeningActivity : Activity
{
    private string _prompt;
    private List<string> _items;

    public ListeningActivity()
        : base("Listing",
               "This activity will help you think broadly by listing as many positive things as you can.")
    {
        _prompt = "List as many things as you can that you are grateful for.";
        _items = new List<string>();
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();

        RunCountDown("You may begin in", 5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _items.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_items.Count} items. Great job!");
        Console.WriteLine();
    }
}