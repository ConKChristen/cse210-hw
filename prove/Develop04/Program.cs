using System;

class Program
{

    static int GetMenuChoice()
    {
        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1.) Start Breathing Activity");
        Console.WriteLine("2.) Start Reflecting Activity");
        Console.WriteLine("3.) Start Listening Activity");
        Console.WriteLine("4.) Quit");
        Console.Write("Please enter the number you want to do: ");

        int input = int.Parse(Console.ReadLine());
        return input;
    }
    static void Main(string[] args)
    {
        bool exit = false;

        while (exit == false)
        {
            int input = GetMenuChoice();

            if (input == 1)
            {
                // this should call the breathing activity
                BreathingActivity b = new BreathingActivity();
                b.Run();
            }
            else if (input == 2)
            {
                // this should call the reflecting activity
                ReflectionActivity r = new ReflectionActivity();
                r.Run();
            }
            else if (input == 3)
            {
                // this should call the relecting activity
                ListeningActivity l = new ListeningActivity();
                l.Run();
            }
            else if (input == 4)
            {
                Console.Write("Thank you. Have a nice day");
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice, please pick between 1-4");
                Console.Clear();
            }
        }
    }
}