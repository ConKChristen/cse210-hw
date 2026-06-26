using System;

class Program
{
    static int GetMenuChoice()
    {
        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1.) Create New Goal");
        Console.WriteLine("2.) List Goals");
        Console.WriteLine("3.) Save Goals");
        Console.WriteLine("4.) Load Goals");
        Console.WriteLine("5.) Record Event");
        Console.WriteLine("6.) Exit");
        Console.Write("Please enter the number you want to do: ");

        int input = int.Parse(Console.ReadLine());
        return input;
    }
    static void Main(string[] args)
    {

        GoalManager manager = new GoalManager();

        bool exit = false;

        while (exit == false)
        {
            Console.WriteLine("");
            Console.WriteLine($"Current Score: {manager.GetScore()}");
            Console.WriteLine("");
            int input = GetMenuChoice();

            if (input == 1)
            {
                //create new goal
                Console.Clear();
                manager.AddGoal();
            }
            else if (input == 2)
            {
                // list of goals
                Console.Clear();
                manager.DisplayGoals();
            }
            else if (input == 3)
            {
                // save goals
                Console.Write("Enter a filename to save to: ");
                string filename = Console.ReadLine();
                manager.SaveGoal(filename);
                Console.WriteLine("Goals saved successfully.");
            }
            else if (input == 4)
            {
                //load goals
                Console.Write("Enter a filename to load from: ");
                string filename = Console.ReadLine();
                manager.LoadGoal(filename);
                Console.WriteLine("Goals loaded successfully.");
            }

            else if (input == 5)
            {
                // record event
                Console.Clear();
                manager.RecordEvent();
            }
            else if (input == 6)
            {
                Console.WriteLine("Thank you for using this program");
                exit = true;
            }
            else
            {
                Console.WriteLine("Please pick a nunmber between 1 and 6");
                Console.Clear();
                return;
            }
        }
    }
}