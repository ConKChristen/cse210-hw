using System;
using System.IO; 

class Program
{
    public static string GetMenuChoice()
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();
        return input;
    }

    static void Main(string[] args)
    {
        List<(Reference, string)> scriptureLibrary = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            (new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me"),
            (new Reference("2 Nephi", 2, 25), "Adam fell that men might be and men are that they might have joy")
        };

        Random rand = new Random();
        int index = rand.Next(scriptureLibrary.Count);

        Reference reference = scriptureLibrary[index].Item1;
        string text = scriptureLibrary[index].Item2;

        Scripture scripture = new Scripture(reference, text);

        bool exit = false;

        while (exit == false)
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine();

            string input = GetMenuChoice();
            
            if (input == "")
            {
                scripture.HideWords();

                if (scripture.IsCompletelyHidden())
                {
                    exit = true;
                }
            }
            else if (input == "quit")
            {
                exit = true;
            }

        }
        Console.WriteLine("All words are hidden or program ended.");
    }
}