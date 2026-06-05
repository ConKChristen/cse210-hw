using System;

class Program
{
    static void Main(string[] args)
    {
        //test for Assignment class
        Assignment test = new Assignment("John", "History");
        Console.WriteLine(test.GetSummary());

        //test for MathAssignment class
        MathAssignment numberTest = new MathAssignment("Peter", "Math", "Math For the Real World", "Page 107 Question 5");
        string mathInfo = numberTest.GetHomeworkList();
        Console.WriteLine(numberTest.GetSummary());
        Console.WriteLine(mathInfo);

        WrittingAssignment writeTest = new WrittingAssignment("James", "English", "War and Peace");
        string writeInfo = writeTest.GetWrittingInformation();
        Console.WriteLine(writeTest.GetSummary());
        Console.WriteLine(writeInfo);
    }
}