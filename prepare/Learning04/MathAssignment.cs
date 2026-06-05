using System;

public class MathAssignment : Assignment
{
    //share student name and topic
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name,string subject, string book, string problem) : base(name, subject)
    {
        _textbookSection = book;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} | Problems: {_problems}";
    }
}